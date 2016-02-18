using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjouteTaFenetre
{
    public partial class Principale : Form
    {
        Dictionary<string, Type> liste;

        public Principale()
        {
            InitializeComponent();
        }

        private void Affiche(object sender, EventArgs e)
        {

            Form instance = (Form)Activator.CreateInstance(liste[((ToolStripMenuItem)sender).Text]);
            instance.MdiParent = this;
            instance.Show();
        }

        private void Principale_Load(object sender, EventArgs e)
        {
            liste = new Dictionary<string, Type>();

            Assembly mscorlib = typeof(Principale).Assembly;
            foreach (Type type in mscorlib.GetTypes())
            {
                if (type.BaseType == typeof(Form) && type.Name != "Principale")
                {
                    liste.Add(type.Name, type);
                    ToolStripMenuItem menuItem = new System.Windows.Forms.ToolStripMenuItem();
                    menuItem.Text = type.Name;
                    menuItem.Click += new System.EventHandler(Affiche);
                    this.fenetresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItem });
                }

            }
        }
    }
}
