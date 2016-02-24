using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using print;

namespace AjouteTaFenetre
{
    public partial class yoyo : Form
    {
        public yoyo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principale p = new principale();
            p.Show();
        }
    }
}
