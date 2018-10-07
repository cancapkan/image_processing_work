using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_homework
{
    public partial class Form2 : Form
    {
        Bitmap kaynak;
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void renkGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xkor.Text);
            int y = int.Parse(ykor.Text);

            Color renk = kaynak.GetPixel(x, y);
            renkbox.BackColor = renk;
            Console.WriteLine(" R: " + renk.R + "  G  " + renk.G + " B  "+renk.B);



        }
    }
}
