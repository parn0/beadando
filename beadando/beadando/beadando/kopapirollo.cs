using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace beadando
{
    public partial class kopapirollo : Form1
    {
        Random rnd = new Random(int.MaxValue);
        string[] gep_elemek = { "KŐ", "PAPIR", "OLLO" };
        string[] visszaszamlalo = { "KŐ", "PAPIR", "OLLO", "1", "2", "3" };
        int jatekos_pont = 0;
        int gep_pont = 0;
        public kopapirollo()
        {
            InitializeComponent();
            
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            rock_pictureBox1.Visible = paper_pictureBox2.Visible = scissor_pictureBox3.Visible = true;


        }

        private void rock_pictureBox1_Click(object sender, EventArgs e)
        {
            int gep = rnd.Next(0, gep_elemek.Length);
            gep_szamlalo.Visible = jatekos_szamlalo.Visible = true;
            if (gep==0)
            {
                //döntetlen
                label2.Visible = true;
                label2.Text = "A meccs döntetlen!";
            }
            else if (gep == 1)
            {
                //gép nyert
                gep_pont++;
                gep_szamlalo.Text = gep_pont.ToString();
                label2.Visible = true;
                label2.Text = "A gép nyert!";
                
            }
            else
            {
                //vesztett a gép
                jatekos_pont++;
                jatekos_szamlalo.Text = jatekos_pont.ToString();
                label2.Visible = true;
                label2.Text = "A játékos nyert!";
                
            }
        }

        private void paper_pictureBox2_Click(object sender, EventArgs e)
        {
            int gep = rnd.Next(0, gep_elemek.Length);
            gep_szamlalo.Visible = jatekos_szamlalo.Visible = true;
            if (gep == 1)
            {
                //döntetlen
                label2.Visible = true;
                label2.Text = "A meccs döntetlen!";
            }
            else if (gep == 2)
            {
                //gép nyert
                gep_pont++;
                gep_szamlalo.Text = gep_pont.ToString();
                label2.Visible = true;
                label2.Text = "A gép nyert!";

            }
            else
            {
                //vesztett a gép
                jatekos_pont++;
                jatekos_szamlalo.Text = jatekos_pont.ToString();
                label2.Visible = true;
                label2.Text = "A játékos nyert!";

            }
        }

        private void scissor_pictureBox3_Click(object sender, EventArgs e)
        {
            int gep = rnd.Next(0, gep_elemek.Length);
            gep_szamlalo.Visible = jatekos_szamlalo.Visible = true;
            if (gep == 2)
            {
                //döntetlen
                label2.Visible = true;
                label2.Text = "A meccs döntetlen!";
            }
            else if (gep == 0)
            {
                //gép nyert
                gep_pont++;
                gep_szamlalo.Text = gep_pont.ToString();
                label2.Visible = true;
                label2.Text = "A gép nyert!";

            }
            else
            {
                //vesztett a gép
                jatekos_pont++; 
                jatekos_szamlalo.Text = jatekos_pont.ToString();
                label2.Visible = true;
                label2.Text = "A játékos nyert!";

            }
        }

    }
}
