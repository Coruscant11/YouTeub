using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YouTeub
{
    public static class YouTubeService
    {
        public static void DownloadVideo(string video_url, string title, string folder_destination, VideoType format, Form1 form)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(video_url);
            VideoInfo video = videoInfos.First(info => info.VideoType == format);
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }
            var videoDownloader = new VideoDownloader(video, Path.Combine(folder_destination, title + video.VideoExtension));
            videoDownloader.DownloadProgressChanged += (sender, args2) => form.SetProgressBarValue(Convert.ToInt32(args2.ProgressPercentage));
            videoDownloader.Execute();

            form.AfterUpload();
        }

        public static void SimpleDownloadVideo(string video_url, string title, string folder_destination, VideoType format, Form1 form)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(video_url);
            VideoInfo video = videoInfos.First(info => info.VideoType == format);
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }
            var videoDownloader = new VideoDownloader(video, Path.Combine(folder_destination, title + video.VideoExtension));
            videoDownloader.DownloadProgressChanged += (sender, args2) => form.SetProgressBarValue(Convert.ToInt32(args2.ProgressPercentage));
            videoDownloader.Execute();
        }

        public static void DownloadMP3(string video_url, string title, string folder_destination, Form1 form)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(video_url);

            VideoInfo video = videoInfos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .First();

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            var audioDownloader = new AudioDownloader(video, Path.Combine(folder_destination, title + video.AudioExtension));

            audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => form.SetProgressBarValue(Convert.ToInt32(85 + args.ProgressPercentage * 0.15));

            audioDownloader.Execute();
            form.AfterUpload();
        }
    }
}
