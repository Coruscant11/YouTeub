namespace YouTeub
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FlashRadio = new System.Windows.Forms.RadioButton();
            this.WebMRadio = new System.Windows.Forms.RadioButton();
            this.MobileRadio = new System.Windows.Forms.RadioButton();
            this.Mp3Radio = new System.Windows.Forms.RadioButton();
            this.Mp4Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ouvrirListeDeVidéosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirListeDeVidéosToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.continueButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL de la vidéo";
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(420, 21);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(117, 27);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continuer";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.downloadButton);
            this.groupBox2.Controls.Add(this.folderButton);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertion";
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(7, 131);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(529, 28);
            this.downloadButton.TabIndex = 6;
            this.downloadButton.Text = "Télécharger la vidéo";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(355, 80);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(181, 45);
            this.folderButton.TabIndex = 5;
            this.folderButton.Text = "Changer dossier de destination";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(460, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dossier :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FlashRadio);
            this.groupBox3.Controls.Add(this.WebMRadio);
            this.groupBox3.Controls.Add(this.MobileRadio);
            this.groupBox3.Controls.Add(this.Mp3Radio);
            this.groupBox3.Controls.Add(this.Mp4Radio);
            this.groupBox3.Location = new System.Drawing.Point(7, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Format";
            // 
            // FlashRadio
            // 
            this.FlashRadio.AutoSize = true;
            this.FlashRadio.Enabled = false;
            this.FlashRadio.Location = new System.Drawing.Point(271, 18);
            this.FlashRadio.Name = "FlashRadio";
            this.FlashRadio.Size = new System.Drawing.Size(63, 21);
            this.FlashRadio.TabIndex = 4;
            this.FlashRadio.Text = "Flash";
            this.FlashRadio.UseVisualStyleBackColor = true;
            // 
            // WebMRadio
            // 
            this.WebMRadio.AutoSize = true;
            this.WebMRadio.Location = new System.Drawing.Point(196, 18);
            this.WebMRadio.Name = "WebMRadio";
            this.WebMRadio.Size = new System.Drawing.Size(69, 21);
            this.WebMRadio.TabIndex = 3;
            this.WebMRadio.Text = "WebM";
            this.WebMRadio.UseVisualStyleBackColor = true;
            // 
            // MobileRadio
            // 
            this.MobileRadio.AutoSize = true;
            this.MobileRadio.Location = new System.Drawing.Point(133, 18);
            this.MobileRadio.Name = "MobileRadio";
            this.MobileRadio.Size = new System.Drawing.Size(57, 21);
            this.MobileRadio.TabIndex = 2;
            this.MobileRadio.Text = "3GP";
            this.MobileRadio.UseVisualStyleBackColor = true;
            // 
            // Mp3Radio
            // 
            this.Mp3Radio.AutoSize = true;
            this.Mp3Radio.Enabled = false;
            this.Mp3Radio.Location = new System.Drawing.Point(70, 18);
            this.Mp3Radio.Name = "Mp3Radio";
            this.Mp3Radio.Size = new System.Drawing.Size(57, 21);
            this.Mp3Radio.TabIndex = 1;
            this.Mp3Radio.Text = "MP3";
            this.Mp3Radio.UseVisualStyleBackColor = true;
            // 
            // Mp4Radio
            // 
            this.Mp4Radio.AutoSize = true;
            this.Mp4Radio.Checked = true;
            this.Mp4Radio.Location = new System.Drawing.Point(7, 18);
            this.Mp4Radio.Name = "Mp4Radio";
            this.Mp4Radio.Size = new System.Drawing.Size(57, 21);
            this.Mp4Radio.TabIndex = 0;
            this.Mp4Radio.TabStop = true;
            this.Mp4Radio.Text = "MP4";
            this.Mp4Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(530, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // ouvrirListeDeVidéosToolStripMenuItem
            // 
            this.ouvrirListeDeVidéosToolStripMenuItem.Enabled = false;
            this.ouvrirListeDeVidéosToolStripMenuItem.Name = "ouvrirListeDeVidéosToolStripMenuItem";
            this.ouvrirListeDeVidéosToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.ouvrirListeDeVidéosToolStripMenuItem.Text = "Ouvrir liste de vidéos";
            this.ouvrirListeDeVidéosToolStripMenuItem.Click += new System.EventHandler(this.ouvrirListeDeVidéosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 313);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(586, 360);
            this.MinimumSize = new System.Drawing.Size(586, 360);
            this.Name = "Form1";
            this.Text = "YouTeub - by Coruscant11";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Mp3Radio;
        private System.Windows.Forms.RadioButton Mp4Radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton WebMRadio;
        private System.Windows.Forms.RadioButton MobileRadio;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.RadioButton FlashRadio;
        private System.Windows.Forms.ToolStripMenuItem ouvrirListeDeVidéosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

