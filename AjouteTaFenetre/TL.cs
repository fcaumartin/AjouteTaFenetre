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
    public partial class TL : Form
    {
        public TL()
        {
            InitializeComponent();
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Hide();
            button1.Show();
            button2.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Hide();
            button1.Show();
            button3.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Show();
            button3.Show();
        }
    }
}
