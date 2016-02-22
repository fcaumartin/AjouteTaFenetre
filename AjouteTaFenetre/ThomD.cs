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
    public partial class ThomD : Form
    {
        public ThomD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
             
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Visible = false;
        }
    }
}
