using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AjouteTaFenetre
{
    public partial class Dovah : Form
    {
        public Dovah()
        {
            InitializeComponent();
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            bool a = Regex.IsMatch(tb_lettre.Text, @"^[ACEFGHIJKLMPQSTVWXYZacefghijklmpqstvwxyz]$");
            LTAP.Visible = true;

            if (tb_lettre.Text != "")
            {

                if (a == false)
                {
                    switch (tb_lettre.Text)
                    {
                        case "b":
                            l1.Text = "B";
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        case "o":
                            l2.Text = "o";
                            l5.Text = "o";
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        case "n":
                            l3.Text = "n";
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        case "d":
                            l4.Text = "d";
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        case "u":
                            l6.Text = "u";
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        case "r":
                            l7.Text = "r";
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        default:
                            MessageBox.Show("Erreur de saisie", "Erreur");
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 1:
                            PB.Image = Properties.Resources._1;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                        case 2:
                            PB.Image = Properties.Resources._2;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                        case 3:
                            PB.Image = Properties.Resources._3;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                        case 4:
                            PB.Image = Properties.Resources._4;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                        case 5:
                            PB.Image = Properties.Resources._5;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                        case 6:
                            i++;
                            PB.Image = Properties.Resources._6;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            break;
                        case 7:
                            PB.Image = Properties.Resources._7;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                        case 8:
                            PB.Image = Properties.Resources._8;
                            LTAP.Text = LTAP.Text + "\n" + tb_lettre.Text + " ";
                            i++;
                            break;
                    }
                }
            }
            tb_lettre.Text = "";
        }
    }
}
