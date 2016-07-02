using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YouTeub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "Entrez le lien de la vidéo";

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }

        /// <summary>
        /// Fonction modifiant la valeur de la barre de progression du téléchargement, et ce via des opération inter-thread
        /// </summary>
        /// <param name="value">Valeur de la progression</param>
        public void SetProgressBarValue(double value)
        {
            progressBar1.BeginInvoke(new Action(() =>
            {
                progressBar1.Value = Convert.ToInt32(value);
            }));
        }

        public void AfterUpload()
        {
            System.Threading.Thread.Sleep(250);

            groupBox1.BeginInvoke(new Action(() =>
            {
                groupBox1.Enabled = true;
            }));
            groupBox2.BeginInvoke(new Action(() =>
            {
                groupBox2.Enabled = false;
            }));

            this.SetProgressBarValue(0);
        }

        /// <summary>
        /// Action du bouton continuer, vérifiant la validité du lien YouTube et activant le groupBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckYoutube(textBox1.Text))
            {
                groupBox2.Enabled = true;
            }
        }

        /// <summary>
        /// Action du bouton choisissant le dossier de destionation du fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string folder = fbd.SelectedPath;
                textBox3.Text = folder;
            }
        }

        /// <summary>
        /// Quand la valeur du texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.CheckDownload();
        }

        /// <summary>
        /// Quand la valeur du text change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.CheckDownload();
        }

        /// <summary>
        /// Vérifie la validité du lien YouTube
        /// </summary>
        /// <param name="video_url"></param>
        /// <returns></returns>
        private bool CheckYoutube(string video_url)
        {
            try
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(textBox1.Text);
                if (videoInfos != null)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de retrouver la vidéo.\nErreur :\n" + ex.Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Vérifie si tout est prêt pour pouvoir télécharger la vidéo
        /// </summary>
        private void CheckDownload()
        {
            string t2 = textBox2.Text.ToLower();
            string t3 = textBox3.Text.ToLower();

            if (t2.Length > 0 && t3.Length > 0)
            {
                if (Directory.Exists(t3))
                {
                    if (!t2.Contains("/") && !t2.Contains("\\") && !t2.Contains("*") && !t2.Contains(":") && !t2.Contains("?") && !t2.Contains("\"") && !t2.Contains("|") && !t2.Contains("<") && !t2.Contains(">"))
                    {
                        downloadButton.Enabled = true;
                    }
                    else downloadButton.Enabled = false;
                }
                else downloadButton.Enabled = false;
            }
            else downloadButton.Enabled = false;
        }


        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (CheckYoutube(textBox1.Text))
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = false;

                string url = textBox1.Text;
                string title = textBox2.Text;
                string folder = textBox3.Text;

                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                downloadButton.Enabled = false;

                VideoType format = this.GetFormat();
                MessageBox.Show(format.ToString());
                switch (format)
                {
                    case VideoType.Mp4:
                        Task.Run(() => { YouTubeService.DownloadVideo(url, title, folder, VideoType.Mp4, this); });
                        break;
                    case VideoType.Mobile:
                        Task.Run(() => { YouTubeService.DownloadVideo(url, title, folder, VideoType.Mobile, this); });
                        break;
                    case VideoType.Flash:
                        Task.Run(() => { YouTubeService.DownloadVideo(url, title, folder, VideoType.Flash, this); });
                        break;
                    case VideoType.WebM:
                        Task.Run(() => { YouTubeService.DownloadVideo(url, title, folder, VideoType.WebM, this); });
                        break;
                    default:
                        Task.Run(() => { YouTubeService.DownloadVideo(url, title, folder, VideoType.Mp4, this); });
                        break;
                }
            }
            else
            {
                downloadButton.Enabled = false;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private VideoType GetFormat()
        {
            if (Mp4Radio.Checked) return VideoType.Mp4;
            else if (Mp3Radio.Checked) return VideoType.Mp4;
            else if (MobileRadio.Checked) return VideoType.Mobile;
            else if (WebMRadio.Checked) return VideoType.WebM;
            else if (FlashRadio.Checked) return VideoType.Flash;

            else return VideoType.Mp4;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ouvrirListeDeVidéosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string folder = fbd.SelectedPath;

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Choisissez le fichier texte contenant les URLs";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] urls = File.ReadAllLines(ofd.FileName);
                    for (int i = 0; i < urls.Length; i++)
                    {
                        string url = urls[i];
                        Task.Run(() => { YouTubeService.DownloadVideo(url, i.ToString(), folder, VideoType.Mp4, this); });
                        while(!(progressBar1.Value >= 100))
                        {

                        }
                        SetProgressBarValue(0);
                    }
                }
            }
        }
    }
}
