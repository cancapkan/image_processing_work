namespace image_homework
{
    partial class Form2
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
            this.renkGetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.xkor = new System.Windows.Forms.TextBox();
            this.ykor = new System.Windows.Forms.TextBox();
            this.renkbox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.renkGetirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // renkGetirToolStripMenuItem
            // 
            this.renkGetirToolStripMenuItem.Name = "renkGetirToolStripMenuItem";
            this.renkGetirToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.renkGetirToolStripMenuItem.Text = "Renk getir";
            this.renkGetirToolStripMenuItem.Click += new System.EventHandler(this.renkGetirToolStripMenuItem_Click);
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(12, 31);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(443, 407);
            this.kaynakbox.TabIndex = 1;
            this.kaynakbox.TabStop = false;
            // 
            // xkor
            // 
            this.xkor.Location = new System.Drawing.Point(552, 31);
            this.xkor.Name = "xkor";
            this.xkor.Size = new System.Drawing.Size(172, 22);
            this.xkor.TabIndex = 2;
            // 
            // ykor
            // 
            this.ykor.Location = new System.Drawing.Point(552, 75);
            this.ykor.Name = "ykor";
            this.ykor.Size = new System.Drawing.Size(172, 22);
            this.ykor.TabIndex = 3;
            // 
            // renkbox
            // 
            this.renkbox.Location = new System.Drawing.Point(554, 138);
            this.renkbox.Name = "renkbox";
            this.renkbox.Size = new System.Drawing.Size(169, 148);
            this.renkbox.TabIndex = 4;
            this.renkbox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renkbox);
            this.Controls.Add(this.ykor);
            this.Controls.Add(this.xkor);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "re";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkGetirToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.TextBox xkor;
        private System.Windows.Forms.TextBox ykor;
        private System.Windows.Forms.PictureBox renkbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}