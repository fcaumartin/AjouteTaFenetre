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
    public partial class StellioDeath : Form
    {
        public StellioDeath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool continuer = true; 
            while(continuer)
            {
                Form BoucleInfini = new Form();
                BoucleInfini.Show();
            }
        }
    }
}
