using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjouteTaFenetre
{
    public partial class Arshess : Form
    {
        int nbr_mine = 0, x = 0, y = 0, bomba = 0;
        // matrice de 9 sur 9
        string[,] carte = new string[10, 10];
        public Arshess()
        {
            InitializeComponent();
        }

        private void Arshess_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
                for (int y = 0; y < 10; y++)
                {
                    Button bt = new Button();
                    bt.Name = "bt-" + x +"-"+ y;
                    bt.Tag = 10*y + x;
                    bt.Click += Bt_Click;
                    table1.Controls.Add(bt, x, y);
                }
            table1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table1.Enabled = false;
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
           string[] test = bt.Name.Split('-');
            int xx = Convert.ToInt32(test[1]);
            int yy = Convert.ToInt32(test[2]);

            Console.WriteLine("{0} {1}", test[1], test[2]);

            if (carte[xx,yy] == "X")
            {
                MessageBox.Show("et hop, une jambe de moins", "Perdu");
                table1.Enabled = false;
                btn_fire.Enabled = true;
                label2.Visible = true;
                bt.Text = "X";
            }
            else
            {
                // les verticales ou l'inverse j'ai un doute
                if (xx != 9)
                {
                    if (carte[xx + 1, yy] == "X")
                        bomba++;
                }
                if (xx != 0)
                {
                    if (carte[xx - 1, yy] == "X")
                        bomba++;
                }
                // les horizontales  ou l'inverse j'ai un doute

                if (yy != 9)
                {
                    if (carte[xx,yy+1] == "X")
                        bomba++;
                }
                if (yy != 0)
                {
                    if (carte[xx, yy-1] == "X")
                        bomba++;
                }
                //les diagonales
                if (xx != 9 && yy != 9)
                {
                    if (carte[xx + 1, yy + 1] == "X")
                        bomba++;
                }
                if (xx != 0 && yy != 0)
                {
                    if (carte[xx - 1, yy - 1] == "X")
                        bomba++;
                }
                if (xx != 9 && yy != 0)
                {
                    if (carte[xx + 1, yy - 1] == "X")
                        bomba++;
                }
                if (xx != 0 && yy != 9)
                {
                    if (carte[xx - 1, yy + 1] == "X")
                        bomba++;
                }
                bt.Text = Convert.ToString(bomba);
                bomba = 0;
            }
        }
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //float h = (panel3.Height-1) / 10f;
            //float w = (panel3.Width-1) / 10f;
            //for (int i = 0; i <= 10; i++)
            //{
            //    g.DrawLine(Pens.Black, 0, h * i, panel3.Width - 1, h * i);
            //    g.DrawLine(Pens.Black, w * i, 0, w * i, panel3.Height - 1);
            //}   
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           // Console.WriteLine(e.X/20 + " " + e.Y/20);
        }

        private void placement()
        {
            Random pos = new Random();
            for (int i = 0; i < nbr_mine; i++)
            {
                do // tant que la case au rand contient dejà une mine on reroll
                {
                    x = pos.Next(0, 10);
                    y = pos.Next(0, 10);
                } while (carte[x, y] == "X");

                carte[x, y] = "X";
                Console.WriteLine("x = {0} y = {1}",x,y);
            }
        }

        private void btn_fire_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Tb_nbr_mine.Text, "^[0-9]{1,2}$"))
            {
                Array.Clear(carte, 0, carte.Length);
                nbr_mine = Convert.ToInt32(Tb_nbr_mine.Text);
                placement();
                btn_fire.Enabled = false;
                table1.Enabled = true;
            }
        }

    }    
}
