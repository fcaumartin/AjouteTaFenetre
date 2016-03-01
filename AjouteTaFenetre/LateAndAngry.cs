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
    public partial class LateAndAngry : Form
    {
        public LateAndAngry()
        {
            InitializeComponent();
        }

        private void LateAndAngry_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://bienvu.net/late.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
