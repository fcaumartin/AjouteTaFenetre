using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace print
{
    public partial class dessin : Form
    { 
        ArrayList DataForm = new ArrayList();

        String NameForm_Selected = null;
        Info_peripherique MyInfoMouse;
        CarCerPol MyCarCerPol;
        public dessin()
        {
            InitializeComponent();
            //REMARQUE IMPORTANTE: il faut mettre true à la propriété doublebuffer
            //celui-ci évite les scintillements, désactiver-le et essayer sans, vous comprendrer
            //on peut l'emplanter aussi avec
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void dessin_Load(object sender, EventArgs e)
        {   
            remise_a_zero();
        }

        void remise_a_zero()
        {
            MyInfoMouse.X = 0;
            MyInfoMouse.Y = 0;
            MyInfoMouse.PremierPointFait = false;   //le premier point d'une forme n'a pas été fait
            MyInfoMouse.Crt_Activer = false;        //la touche Control n'est pas actionné

            this.listView1.View = View.Details;
            this.listView1.Columns.Add("n°", 30);
            this.listView1.Columns.Add("Nom forme", 150);
            this.listView1.Columns.Add("point départ", 100);
            this.listView1.Columns.Add("point final", 100);
            this.listView1.Columns.Add("dimension", 100);
            this.listView1.Columns.Add("nbr de cotés", 100);
            this.listView1.Columns.Add("Couleur",100);
        }
        private void tool_Click(object sender, EventArgs e)
        {
            //création d'une struct Mycarcerpol celle-ci servira de temporaire
            MyCarCerPol = new CarCerPol();      
            //on definie le nbe de coté définie par nsommet( un toolstristatueplabel )
            MyCarCerPol.Nbr_de_Cote = Convert.ToInt32(nsommet.Text);
            //on definie la couleur par coloractuel ( un toolstristatueplabel )
            MyCarCerPol.Couleur = colorActuel.BackColor;
            //REMARQUE: je prends le toolstristatuslabel car il est visuel
            //ainsi, il n'aura pas d'erreur de couleur ou de nbr de coté

            //sender.Tostring() retourne le 'name' de toolstrip que j'ai prédifinie pour nommer la figure
            NameForm_Selected = sender.ToString();
            //on n'oublie pas de le mettre dans toolStripForm a jour
            toolStripForm.Text = NameForm_Selected;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            MyInfoMouse.PremierPointFait = false;
            toolStripDimension.Text = "0:0";
        }

        private void dessin_MouseDown(object sender, MouseEventArgs e)
        {
            switch( e.Button)
            {
                case MouseButtons.Left:// on a cliquer sur le boutton gauche
                    if (NameForm_Selected == null)
                        return;
                    //on enregistre le 1°point, le point de depart de la figure
                    MyInfoMouse.X = e.X;
                    MyInfoMouse.Y = e.Y;
                    MyInfoMouse.PremierPointFait = true;//on signale que le 1°point a été definie
                    //on enregistre les informations à la carcerpol en cours
                    MyCarCerPol.nameform = NameForm_Selected;
                    MyCarCerPol.Couleur = colorActuel.BackColor;
                    MyCarCerPol.Xd = e.X;
                    MyCarCerPol.Yd = e.Y;
                    break;

                case MouseButtons.Right:
                    //active le contexmenu
                    choississez.Show(this,e.X, e.Y);
                    break;
            }
        }

        //se déclenche lors d'un relâchement d'un button
        private void dessin_MouseUp(object sender, MouseEventArgs e)
        {            
            if (MyInfoMouse.PremierPointFait == true)
            { //on réinitialise premierpointfait pour une prochaine forme
                MyInfoMouse.PremierPointFait = false;
                
                //on donne xd,xf et en retour nous avons xd<xf
                Myfonction.inverse(ref MyCarCerPol.Xd, ref MyCarCerPol.xf);
                Myfonction.inverse(ref MyCarCerPol.Yd, ref MyCarCerPol.yf);
                
                //on stocke la mycarcerpol dans dataform et affiche dans listview        
                
                ListViewItem lst = new ListViewItem();
                lst.Text=DataForm.Add(MyCarCerPol).ToString();
                lst.SubItems.Add(MyCarCerPol.nameform);
                lst.SubItems.Add(MyCarCerPol.Xd + ":" + MyCarCerPol.Xf);
                lst.SubItems.Add(MyCarCerPol.Yd + ":" + MyCarCerPol.Yf);
                lst.SubItems.Add(MyCarCerPol.DimX + ":" + MyCarCerPol.DimY);
                lst.SubItems.Add(MyCarCerPol.Nbr_de_Cote.ToString());
                lst.SubItems.Add(MyCarCerPol.Couleur.Name);
                listView1.Items.Add(lst);

                toolStripDimension.Text = "( 0:0 )";
            }
        }

        private void dessin_MouseMove(object sender, MouseEventArgs e)
        {
            if (MyInfoMouse.PremierPointFait == true)
            {
                //affiche la dimension de la forme
                toolStripDimension.Text = "( " + Math.Abs(e.X - MyInfoMouse.X).ToString("d4") + " : " + Math.Abs(e.Y - MyInfoMouse.Y).ToString("d4") + " )";
                //on stocke le point final
                MyCarCerPol.Xf = e.X;
                MyCarCerPol.Yf = e.Y;
                if (MyCarCerPol.DimX == 0 || MyCarCerPol.DimY == 0)
                    return;

                //si la touche control est activé, on défine la dim x = dim y
                if (MyInfoMouse.Crt_Activer == true || MyCarCerPol.nameform=="Rosace")
                    MyCarCerPol.Yf = MyCarCerPol.Yd + MyCarCerPol.DimX*Math.Sign(MyCarCerPol.Yf-MyCarCerPol.Yd);
                //REMARQUE: Math.Signe retourne 1 si > à zéro -1 si < à zéro et 0 si égal;
                // on aurai pu écrire
                //      if (MyInfoMouse.Crt_Activer == true)
                //      {
                //          int val = MyCarCerPol.Yf - MyCarCerPol.Yd;
                //          if( val>0 ) val = 1;
                //          else        val = -1;
                //      
                //          MyCarCerPol.Yf = MyCarCerPol.Yd + MyCarCerPol.DimX * val;
                //      }
                
                //on redessine le control, ici la fenêtre et ses controles enfants
                Refresh();
            }
            else
                //affiche la position actuelle de la sourie
                toolStripPostion.Text = "( " + e.X.ToString("d4") + " : " + e.Y.ToString("d4") + ")";
        }

        //la planche a dessin de la fenêtre
        private void dessin_Paint(object sender, PaintEventArgs e)
        {
            foreach (CarCerPol i in DataForm)
                Myfonction.affiche_paint(e.Graphics, i);//dessine chaque objet carcerpol
            //REMARQUE: affiche_paint se trouve la classe Myfonction, on lui donne un paramètre graphics
            //auquel il doit dessiner.
            if (MyCarCerPol.nameform != null)//dessine l'objet temporaire
                Myfonction.affiche_paint(e.Graphics, MyCarCerPol);
        }

        //demande l'impression
        private void toolprint_Click(object sender, EventArgs e)
        {
            //si aucun objet dans dataform, on sort
            if (DataForm.Count == 0)
                return;
            
            //on affiche la boite de dialogue pour l'impresion
            //on definie le format, portrait ou paysage, recto-verso etc...
            if (this.PrintDialog.ShowDialog() != DialogResult.OK)
                return;
            
            //on donne le document à imprimer à l'aperçu
            PrintApercu.Document = PrintPage;

            //on affiche l'aperçu
            if (PrintApercu.ShowDialog() != DialogResult.OK)
                return;
        }

        // debut de l'impression
        
        //a ne pas oublier d'initialiser les nbrdepage;
        int nbrdepageH = 0;//nbr de page horizontale
        int nbrdepageV = 0;//nbr de page verticale

        private void PrintPage_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {            
            int xmin=0,xmax=0,ymin=0,ymax=0;
            int NbrdePageHorizontale = 0;
            int NbrdePageVerticale = 0;

            //on enregistre la zone impression dans un rectangle, suivant les caractéristiques donnée dans printdialog            
            Rectangle rct = e.PageSettings.Bounds;
            
            ArrayList CloneDataForm = new ArrayList();
            CloneDataForm = (ArrayList)DataForm.Clone();
            
            //détermine les extrémitées que prend le dessin
            Myfonction.calcul_extremun(ref xmin, ref xmax, ref ymin, ref ymax, CloneDataForm);            
            
            //on calcul la dimension en X et Y
            float Xdelta = xmax - xmin;
            float Ydelta = ymax - ymin;

            //dessin ajusté à la page ?
            float rapportIdeale = 1;
            if( AjusterPage.Checked == true)
            {
                float rapportX;
                float rapportY;           
                //calcul les rapports entre le réel et la page
                rapportX = (float)rct.Width/Xdelta;
                rapportY = (float)rct.Height/Ydelta;
                //determine lequel est plus avantageux
                rapportIdeale = (rapportX < rapportY) ? rapportX : rapportY;
                //remet à l'echelle
                for (int i = 0; i < CloneDataForm.Count; i++)
                {
                    CarCerPol item_ = Copy_ccp( (CarCerPol)CloneDataForm[i] );
                    item_.Xd = (int)(item_.Xd*rapportIdeale);
                    item_.Xf = (int)(item_.Xf*rapportIdeale);
                    item_.Yd = (int)(item_.Yd*rapportIdeale);
                    item_.Yf = (int)(item_.Yf*rapportIdeale);
                    CloneDataForm.RemoveAt(i);              //supprime l'element
                    CloneDataForm.Insert(i, item_);         //remet l'element modifier
                }
                xmin = (int) (xmin * rapportIdeale);
                ymin = (int) (ymin * rapportIdeale);
            }else
            {               
                //on calcule le nbr de page horizontale et verticale
                NbrdePageHorizontale =(int) Xdelta / rct.Width;
                NbrdePageVerticale = (int)Ydelta / rct.Height;
            }  
            if( centerH.Checked == true)
            {
                Xdelta = (int)(Xdelta * rapportIdeale );
                xmin -=(int) (rct.Width * (NbrdePageHorizontale+1) - Xdelta) /2;
            }

            if (centerV.Checked == true)
            {
                Ydelta = (int)(Ydelta * rapportIdeale);
                ymin -=(int) (rct.Height * (NbrdePageVerticale + 1) - Ydelta)/2;
            }
            //on deplace le dessin en fonction des pages à imprimer
            //autrement dit, on modifie l'origine
            e.Graphics.TranslateTransform(-nbrdepageH * rct.Width-xmin, -nbrdepageV * rct.Height-ymin);

 //////////////////////////////////////////////////////////////////////////////////////////////////
            //la zone ou dessine

            //on dessine les formes
            foreach (CarCerPol i in CloneDataForm)
                Myfonction.affiche_paint(e.Graphics, i);

            //fin de la à dessiner
///////////////////////////////////////////////////////////////////////////////////////////////////

        //on teste si le nbr de page horizontale est atteinte
           if (nbrdepageH != NbrdePageHorizontale)
            {
               //pas atteint on signale qu'une autre page va être dessiner
                e.HasMorePages = true;
               //on n'oublie pas d'incrémenter nbr de page horizontale
                nbrdepageH++;
            }
            else
                if (nbrdepageV != NbrdePageVerticale)
                {
                    //pas atteint on signale qu'une autre page va être dessiner
                    e.HasMorePages = true;
                    //on n'oublie pas d'incrémenter nbr de page verticale
                    nbrdepageV++;
                    //NE PAS OUBLIER DE REMETTRE A ZERO NBR DE PAGE HORIZONTALE
                    nbrdepageH = 0;
                }
                else
                {
                    //toutes les pages ont été imprimer
                    e.HasMorePages = false;
                    //NE PAS OUBLIER DE REMETTRE A ZERO NBR DE PAGE HORIZONTALE et VERTICALE pour une prochaine impression
                    nbrdepageV = nbrdepageH = 0;
                }
        }
        
        //creer une copy d'un carcerpol
        CarCerPol Copy_ccp( CarCerPol ccp )            
        {
            CarCerPol ccpi = new CarCerPol();
            ccpi.Couleur = ccp.Couleur;
            ccpi.nameform = ccp.nameform;
            ccpi.Nbr_de_Cote = ccp.Nbr_de_Cote;
            ccpi.Xd = ccp.Xd;
            ccpi.Yd = ccp.Yd;
            ccpi.Xf = ccp.Xf;
            ccpi.Yf = ccp.Yf;
            return ccpi;
        }
        //efface tout l'ecran
        private void toolClear_Click(object sender, EventArgs e)
        {
            //on efface l'ecran avec une couleur
            this.CreateGraphics().Clear(BackColor);
            //efface les donnees de dataform
            DataForm.Clear();
            listView1.Items.Clear();
            //on met le nameform a vide, pas de forme selectionnée
            MyCarCerPol.nameform = null;
            toolStripForm.Text = "pas de forme";
        }

        private void toolChoixColor_Click(object sender, EventArgs e)
        {
            //sender est l'object qui a été selectionné
            ToolStripMenuItem tpm = (ToolStripMenuItem)sender;
            colorActuel.BackColor = tpm.BackColor;
            MyCarCerPol.Couleur = tpm.BackColor;
        }

        private void dessin_KeyDown(object sender, KeyEventArgs e)
        {
            MyInfoMouse.Crt_Activer = e.Control;
            this.ToucheControl.Text = "Controle";
        }

        private void dessin_KeyUp(object sender, KeyEventArgs e)
        {
            MyInfoMouse.Crt_Activer = e.Control;
            this.ToucheControl.Text = "not key Control";
        }

        private void nombreDeSegemnt_Click(object sender, EventArgs e)
        {
            //sender est l'objet qui a été selectionnée
            //on le stocke dans la carcerpol temporaire
            MyCarCerPol.Nbr_de_Cote = Convert.ToInt32(sender.ToString());
            //ne pas oublier le toolstripstatuspanel
            nsommet.Text = MyCarCerPol.Nbr_de_Cote.ToString();
        }
    }
}
