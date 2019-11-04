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
    public partial class szamkitalalo : Form1
    {
        Random rnd = new Random();
        string[] intervallum = new string[2];
        int random = 0;
        int szamlalo = 0;
        public szamkitalalo()
        {
            InitializeComponent();
            label4.Visible = false;
            textBox2.Visible = false;

        }
        public void szamkitalalo_fg(string be)
        {

            #region szamkit
            if (be == "Tipped!")
            {
                MessageBox.Show($"Kérlek adj meg egy számot a megadott intervallumon belül!({intervallum[0]}-{intervallum[1]})");
            }
            else
            {
                label5.Visible = true;
                if (int.Parse(be) > random)
                {
                    szamlalo++;
                    label5.Text = $"Az általad megadott szám nagyobb. Próbállkozások száma ({szamlalo})";
                    
                }
                else if (random > int.Parse(be))
                {
                    szamlalo++;
                    label5.Text = $"Az általad megadott szám kisebb. Próbálkozások száma ({szamlalo})";
                    
                }
                else
                {
                    label5.Text = $"Eltaláltad! A gondolt szám a(z) {random}";
                    label6.Visible = true;
                    label6.Text = $"Játék újra kezdéséhez kérlek adj meg \núj intervallumot és nyomj a {start_button1.Text} gombra";
                }


            }
            #endregion
        }
        private void start_button1_Click(object sender, EventArgs e)
        {

            label5.Visible = label6.Visible = false;
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Nincs megadva megfelőlő karakterlánc!");
            }
            else
            {

                intervallum = textBox1.Text.Split('-');
                random = rnd.Next(int.Parse(intervallum[0]), int.Parse(intervallum[1]));
                //label4.Text = rnd.Next(int.Parse(intervallum[0]), int.Parse(intervallum[1])).ToString();
            }
            label4.Visible = true;
            textBox2.Visible = true;
            label4.Text = $"Találdi ki melyik számra gondolt a gép ezen az intervallumon belül: {intervallum[0]} - {intervallum[1]} .";
            mehet_button2.Visible = true;
            //label7.Text = random.ToString();

        }

        private void mehet_button2_Click(object sender, EventArgs e)
        {

            szamkitalalo_fg(textBox2.Text);
        }
    }
}
