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
    public class ExtractChannel : BaseFilter
    {
        public ExtractChannel()
        {
        }
    }
    public partial class Form3 : Form
    {
        Bitmap kaynak, sonuc;
        public Form3()
        {
            InitializeComponent();
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

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);
                    int ort = (renklirenk.R + renklirenk.G + renklirenk.B)/3;
                    Color siralirenk = Color.FromArgb(ort,ort,ort);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);
                    float luma = (renklirenk.R *0.3f) + (renklirenk.G * 0.59f) + (renklirenk.B *0.11f);

                    Color siralirenk = Color.FromArgb((int)luma, (int)luma,(int)luma);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);
                    int acıklık = (Math.Max(Math.Max(renklirenk.R,renklirenk.B), renklirenk.G) + Math.Min(Math.Max(renklirenk.R, renklirenk.B), renklirenk.G)) / 2;
                    Color siralirenk = Color.FromArgb(acıklık, acıklık, acıklık);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);
            
            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);

                    Color siralirenk = Color.FromArgb(renklirenk.R, renklirenk.R, renklirenk.R);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);

                    Color siralirenk = Color.FromArgb(renklirenk.B, renklirenk.B, renklirenk.B);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);

                    Color siralirenk = Color.FromArgb(renklirenk.G, renklirenk.G, renklirenk.G);
                    sonuc.SetPixel(x, y, siralirenk);

                }

            }
            sonucbox.Image = sonuc;
        }

        private void bT709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            sonuc = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renklirenk = kaynak.GetPixel(x, y);
                    float bt = (renklirenk.R * 0.2125f) + (renklirenk.G * 0.7154f) + (renklirenk.B * 0.072f);

                    Color siralirenk = Color.FromArgb((int)bt, (int)bt, (int)bt);
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
