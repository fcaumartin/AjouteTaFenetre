using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace print
{
    public partial class principale : Form
    {
        Form[] enfant;
        public principale()
        {
            InitializeComponent();            
        }

        private void nouveauDessinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dessin ds = new dessin();
            //on précise que la fenêtre enfant appartient à la fenêtre parent ( principale )
            ds.MdiParent = this; //Attention, ne pas oublier de mettre true à IsMdiContainer
            ds.Show();
            // MdiChildren retourne un tableau de tous les fenêtres enfants active
            enfant = MdiChildren; 
            ds.Text += " n°" + enfant.Length.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ImpressionText im = new ImpressionText();
            im.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PositionToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //réorganise la présentation des fenêtres
            switch(sender.ToString())
            {
                case "cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case"TileHorizontal":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;

                case "TileVertical":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
            }
        }

        private void reduireTousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //réduit toutes les fenetres enfants
            foreach (Form item in enfant)                                           //on peut le faire avec for
                item.WindowState = FormWindowState.Minimized;                       //for(int i=0;i<enfant.Lenght;i++)                
        }                                                                           //{
                                                                                    //      Form item = (Form) enfant.Items[i];
        private void fermeTousToolStripMenuItem_Click(object sender, EventArgs e)   //      item.WindowState = FormWindowsState.Minimized;
        {                                                                           //}
            //ferme tous les fenetres enfants
            foreach (Form item in enfant)
                item.Close();
        }
    }
}
