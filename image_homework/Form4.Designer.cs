namespace image_homework
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.sonucbox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBBRGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBGBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonucbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kanalSıralaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kanalSıralaToolStripMenuItem
            // 
            this.kanalSıralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBBRGToolStripMenuItem,
            this.rGBGBRToolStripMenuItem});
            this.kanalSıralaToolStripMenuItem.Name = "kanalSıralaToolStripMenuItem";
            this.kanalSıralaToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kanalSıralaToolStripMenuItem.Text = "Kanal sırala";
            this.kanalSıralaToolStripMenuItem.Click += new System.EventHandler(this.kanalSıralaToolStripMenuItem_Click);
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(12, 31);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(373, 407);
            this.kaynakbox.TabIndex = 1;
            this.kaynakbox.TabStop = false;
            // 
            // sonucbox
            // 
            this.sonucbox.Location = new System.Drawing.Point(406, 31);
            this.sonucbox.Name = "sonucbox";
            this.sonucbox.Size = new System.Drawing.Size(373, 407);
            this.sonucbox.TabIndex = 2;
            this.sonucbox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // rGBBRGToolStripMenuItem
            // 
            this.rGBBRGToolStripMenuItem.Name = "rGBBRGToolStripMenuItem";
            this.rGBBRGToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rGBBRGToolStripMenuItem.Text = "RGB>BRG";
            this.rGBBRGToolStripMenuItem.Click += new System.EventHandler(this.rGBBRGToolStripMenuItem_Click);
            // 
            // rGBGBRToolStripMenuItem
            // 
            this.rGBGBRToolStripMenuItem.Name = "rGBGBRToolStripMenuItem";
            this.rGBGBRToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rGBGBRToolStripMenuItem.Text = "RGB>GBR";
            this.rGBGBRToolStripMenuItem.Click += new System.EventHandler(this.rGBGBRToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sonucbox);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sonucbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalSıralaToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.PictureBox sonucbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBBRGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBGBRToolStripMenuItem;
    }
}