using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace print
{
    public partial class ImpressionText : Form
    {
        public ImpressionText()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on initialise le texte dans listbox
            for (int i = 1; i <= 450; i++)
                this.listBox1.Items.Add("Print line n°"+i.ToString("D3"));
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() != DialogResult.OK)
                return;

            // on créer efface les élément et les colunnes du control listview
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.CheckBoxes = true; //on présice la présente d'un checkbox
            listView1.Columns.Add("",20);//1 iere colonnes là où se trouve le checkbox
            listView1.Columns.Add("name",300);
            listView1.Columns.Add("dimension",150);
            //on ajoute les types de papiers de l'imprimante sélectionnée: printSetting nous donne toutes les infos sur l'imprimante
            foreach (PaperSize item in printDialog1.PrinterSettings.PaperSizes)//on extrait chaque élement du tableau PaperSizes dans item
            {
                ListViewItem lst = new ListViewItem();          //créer une ligne
                lst.SubItems.Add(item.PaperName);                 //ajoute le nom du papier
                lst.SubItems.Add( item.Width  + "X"+ item.Height); //ajoute le format du papier
                listView1.Items.Add( lst );                     //ajoute la ligne à Listview
            }
        } 
        
        // on initialise l'imprimante        
        int countPage = 0;  //variable pour le nbr de ligne
        int countTotal = 0; //numero de page

        //printpage est déclenché lors d'une demande d'impression
        private void PageImpression_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            
            //printablarea retourne un rectangle qui prend la dimension definie par la zone maximal pour l'impression
            RectangleF rct = e.PageSettings.PrintableArea;
         
            float xd = rct.X;
            float yd = rct.Y;

            e.Graphics.DrawRectangle( new Pen(Brushes.Black),rct.X,rct.Y,rct.Width,rct.Height);  //on dessine la zone imprimable est représenté par le rectangle

            //calcul le nombre de page, rct.Height est la hauteur de la page imprimable et Font.height la hauteur de l'interligne de la police
            //ici Font est la police de la fenêtre impression
            int NbrDeligneParPage = (int)(rct.Height / Font.Height);                                                                                            

            if (this.listBox1.Items.Count < NbrDeligneParPage)         //si le nbr de ligne à imprimer est inférieur au nombre de ligne par page
                NbrDeligneParPage = listBox1.Items.Count;              //alors nbrdeligneparpage est égale au nombre de ligne à imprimer
            
            while( NbrDeligneParPage != countPage )
            {
                //on prend le text au rang countTotal
                String mot = listBox1.Items[countTotal].ToString();   

                //on dessine le mot dans graphics à la position x=xd, y=yd+Font.Heigth*countPage
                //le point est toujours en haut à gauche du texte
                e.Graphics.DrawString(mot, Font, Brushes.Black, xd, yd+Font.Height*countPage);                

                //on passe à la ligne suivante de la page actuelle et total
                countPage++;
                countTotal++;

                //on verifie si on a atteint toutes les lignes à imprimer si égale on sort de la boucle while
                if (countTotal == this.listBox1.Items.Count)
                    break;
            }
            //si on ne l'a pas atteint
            //on initialise countPage
                countPage = 0;

            //on verifie si on a pas atteint toutes les lignes à imprimer
            if (countTotal == listBox1.Items.Count)
            {//si on atteint, on signale qu'il n'y a plus de page à imprimer en mettant true à e.hasmorepages
                 e.HasMorePages = false;
                countTotal = 0;//on n'oublie pas d'initialisé le nombre de page à 0 pour la prochaine impression
            }
            else
            {
                //on signale qu'une nouvelle doit être dessiner
                //celui-ci recommence au debut de printPage, de ce fait, faite attention de bien vérifier d'imprimer la prochaine page
                e.HasMorePages = true;
            }                
        }

        //listView1_MouseDown est déclencher lors d'un clic d'un boutton
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            //hitTest retourne la ligne à la position de la sourie au moment d'un clic sur l'un des bouttons
            //on peut connaître le boutton grace à e.Button qui retourne MouseButton
            
            ListViewHitTestInfo lst = listView1.HitTest(e.X, e.Y);
            //on controle si l'object lst n'est pas null
            if (lst == null)
                return;
            //on donne le format du papier à PageImpression
            PageImpression.DefaultPageSettings.PaperSize = printDialog1.PrinterSettings.PaperSizes[lst.Item.Index];
            //on donne ensuite au document de l'aperçu
            ApercuImpression.Document = PageImpression;
            //on affiche l'aperçu
            if (ApercuImpression.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}