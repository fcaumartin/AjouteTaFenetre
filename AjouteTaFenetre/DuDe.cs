using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjouteTaFenetre
{
    public partial class DuDe : Form
    {
        public DuDe()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Mémorise le avec \nton cerveau ton \nmot de passe !!!!", "!!!! NaN !!!!");
                checkBox1.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label4.Visible = true;
                label4.ForeColor = Color.HotPink;
                label4.Font = new Font(label4.Font, FontStyle.Bold);
                label4.Text = "Mot de passe COCHON... \nHMMMM !!!! COQUINOU !!!!";
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nom d'utilisateur : ERREUR !!!! \n\n            OU \n\nMot de passe : ERREUR !!!!", "Raté, Recommence !!!!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Jipih" || comboBox1.Text == "Arshess" || comboBox1.Text == "AsThom" || comboBox1.Text == "Dovah" || comboBox1.Text == "Supa" || comboBox1.Text == "Who")
            {
                label5.Visible = true;
                label5.ForeColor = Color.HotPink;
                label5.Font = new Font(label4.Font, FontStyle.Bold);
                label5.Text = "Bah alors tu viens plus aux soirées !!!!";
            }
           

            if (comboBox1.Text == "François" || comboBox1.Text == "DuDe")
            {
                label5.Visible = true;
                label5.ForeColor = Color.DarkBlue;
                label5.Font = new Font(label4.Font, FontStyle.Bold);
                label5.Text = "Tiens vlà le meilleur !!!!";
            }

            if (comboBox1.Text.Length == 0)
            {
                label5.Visible = false;
            }
           

            
        }
    }
}
