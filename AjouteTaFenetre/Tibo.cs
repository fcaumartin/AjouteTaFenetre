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
    public partial class Tibo : Form
    {
        public Tibo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ne soyez pas si négatif je suis sûre que vous faites de votre mieux");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "Non";
            button2.Text = "Oui";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Oui";
            button2.Text = "Non";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ne soyez pas si négatif je suis sûre que vous faites de votre mieux");
        }
    }
}
