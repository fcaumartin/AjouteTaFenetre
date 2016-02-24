using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace print
{
    public struct Info_peripherique
    {
        public int X;
        public int Y;
        public bool PremierPointFait;
        public bool Crt_Activer;
    }

    public struct CarCerPol
    {
        public String nameform;
        public int Xd, Yd;
        public int DimX, DimY;
        public Color Couleur;
        public int Nbr_de_Cote;

        public int xf, yf;
        public int Xf
        {
            set
            {
                int v = xf = value;
                DimX = Math.Abs(Xd - xf);
            }
            get { return xf; }
        }
        public int Yf
        {
            set
            {
                int v = yf = value;
                DimY = Math.Abs(Yd - yf);
            }
            get { return yf; }
        }
    }

}
