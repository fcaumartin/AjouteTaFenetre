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
    public partial class MaisQuEstCeQueJeVaisFaire : Form
    {
        
        public MaisQuEstCeQueJeVaisFaire()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (button1.Visible == false)
            {
                label1.Visible = true;
                label1.Text = "Finie la br***ette !!!!";
                pictureBox2.Visible = true;
                //declenchement du son mp3
                axWindowsMediaPlayer1.URL = "http://www.soundjay.com/misc/sounds/fail-trombone-01.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.play();


            }

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {


        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
                 
        }

        private void MaisQuEstCeQueJeVaisFaire_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
