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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkform = new Form2();
            renkform.ShowDialog();
        }

        private void griYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 griform = new Form3();
            griform.ShowDialog();
        }

        private void kanalSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 griform = new Form4();
            griform.ShowDialog();

         }
    }
}
