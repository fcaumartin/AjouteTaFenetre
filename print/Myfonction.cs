using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print
{
    public class Myfonction
    {
        public static void dessine_polygone(Graphics g, Brush col, int xp, int yp, int D1, int D2, int nbrpolygone)
        {
            //calcul l'angle par point
            float angle = (float)(2 * Math.PI / nbrpolygone);

            //R1 et R2 sont les dimensions, donc pour connaître le rayon on divise par 2
            float r1 = D1 >> 1;//>> signifie deplacement des bits vers la droite soit diviser par 2
            float r2 = D2 >> 1;//si >>2 c'est /4, >>3 /8, >>4 /16 etc... 2 à la puissance n
            //inversement << on mutiplie

            PointF[] datasommet = new PointF[nbrpolygone + 1];
            //calculs et stocks les sommets
            for (int i = 0; i < nbrpolygone; i++)
            {
                //on détermine le point en fonction de l'angle
                datasommet[i].X = (float)(r1 * Math.Cos(angle * i) + xp + r1);
                datasommet[i].Y = (float)(r2 * Math.Sin(angle * i) + yp + r2);
            }
            //on rajoute le 1° point afin de fermer le polygone
            datasommet[nbrpolygone].X = (float)(r1 + xp + r1);
            datasommet[nbrpolygone].Y = (float)(yp + r2);
            
            //on dessine le polygone
            g.DrawLines(new Pen(col), datasommet);
        }

        public static void dessine_polygone_cercle(Graphics g, Brush col, int xp, int yp, int D1, int D2, int nbrpolygone)
        {
            float r1 = D1 >> 1;
            float r2 = D2 >> 1;

            PointF[] datasommet = new PointF[nbrpolygone];
            
            float angle = (float)(2 * Math.PI / nbrpolygone);

            //calculs et stocks les sommets
            for (int i = 0; i < nbrpolygone; i++)
            {
                datasommet[i].X = (float)(r1 * Math.Cos(angle * i) + xp + r1);
                datasommet[i].Y = (float)(r2 * Math.Sin(angle * i) + yp + r2);
            }

            //trace les lignes
            float x1, y1, x2, y2;
            for (int i = 0; i < nbrpolygone; i++)
            {
                x1 = datasommet[i].X;
                y1 = datasommet[i].Y;
                for (int j = 0; j < nbrpolygone; j++)
                {
                    if (i == j)//si c'est le même point
                        continue;//on passe à la suivante

                    x2 = datasommet[j].X;
                    y2 = datasommet[j].Y;
                    //on dessin la ligne
                    g.DrawLine(new Pen(col), x1, y1, x2, y2);
                }
            }
        }

        public static void dessine_rosace(Graphics g, Brush col, int xp, int yp, int D1, int D2)
        {
            float r1 = D1>>1;
            float r2 = D2>>1;
            for (int i = 0; i < 6; i++)
            {
                float x1 = (float)(r1 * Math.Cos(i * Math.PI / 3));
                float y1 = (float)(r2 * Math.Sin(i * Math.PI / 3));
                g.DrawArc(new Pen(col), xp+x1, yp+y1, D1, D2,i *60+ 120,120);
            }
        }

        public static void affiche_paint(Graphics g, CarCerPol ccp)
        {
            //syntax afin d'éviter d'écrire
            //if( ccp.Xp>ccp.Xf )    xp = ccp.xf
            //else                   xp = ccp.yf;

            int xp = (ccp.Xd > ccp.Xf) ? ccp.Xf : ccp.Xd;
            int yp = (ccp.Yd > ccp.Yf) ? ccp.Yf : ccp.Yd;

            //definie une couleur Brushes avec Color
            SolidBrush col = new SolidBrush(ccp.Couleur);

            //on dessine l'objet selon nameform qui est le nom de la forme
            switch (ccp.nameform)
            {
                case "Carree":
                    g.DrawRectangle(new Pen(col), xp, yp, ccp.DimX, ccp.DimY);
                    break;

                case "Cercle":
                    g.DrawEllipse(new Pen(col), xp, yp, ccp.DimX, ccp.DimY);
                    break;

                case "Polygone cercle":
                    Myfonction.dessine_polygone_cercle(g, col, xp, yp, ccp.DimX, ccp.DimY, ccp.Nbr_de_Cote);
                    break;

                case "Polygone":
                    Myfonction.dessine_polygone(g, col, xp, yp, ccp.DimX, ccp.DimY, ccp.Nbr_de_Cote);
                    break;

                case "Rosace":
                    Myfonction.dessine_rosace(g, col, xp, yp, ccp.DimX, ccp.DimY);
                    break;
            }
        }
        //retourne les extremuns en fonction d'un tableau carcerpol
        public static void calcul_extremun(ref int xmin, ref int xmax, ref int ymin, ref int ymax, ArrayList dataf)
        {
            int xd, xf, yd, yf;
            bool PremierPassage = true;
            foreach (CarCerPol item in dataf)
            {
                xd = item.Xd;
                xf = item.Xf;
                //on donne xd et xf et en sortie nous avonx xd<xf
                inverse(ref xd, ref  xf);

                yd = item.Yd;
                yf = item.Yf;
                inverse(ref yd, ref yf);

                if (PremierPassage)
                {
                    xmin = xd;
                    xmax = xf;
                    ymin = yd;
                    ymax = yf;
                    PremierPassage = false;
                }
                else
                {
                    if (xd < xmin) xmin = xd;
                    if (xf > xmax) xmax = xf;
                    if (yd < ymin) ymin = yd;
                    if (yf > ymax) ymax = yf;
                }
            }
        }

        public static void inverse(ref int vd, ref int vf)
        {
            if (vd > vf)
            {
                int v = vd;
                vd = vf;
                vf = v;
            }
        }
    }//fin class MyFonction
}
