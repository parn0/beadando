using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kőpapírollóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kopapirollo uj = new kopapirollo();
            uj.Show();
        }

        private void számkitalálóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szamkitalalo uj = new szamkitalalo();
            uj.Show();
        }


    }
}
