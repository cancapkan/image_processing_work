using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_homework
{
    public partial class Form4 : Form
    {
        Bitmap kaynak,sonuc;
        public Form4()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult foto = openFileDialog1.ShowDialog();
            if (foto == DialogResult.OK) ;
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakbox.Image = kaynak;

            }
        }

        private void kanalSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rGBBRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);

                    Color siralirenk = Color.FromArgb(renklirenk.B, renklirenk.R, renklirenk.G);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void rGBGBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);

                    Color siralirenk = Color.FromArgb(renklirenk.G, renklirenk.B, renklirenk.R);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult islem = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (islem == DialogResult.OK)
            {
                sonuc.Save(saveFileDialog1.FileName, format);
            }
        }
    }
    
}
