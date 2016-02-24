namespace print
{
    partial class dessin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dessin));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPostion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDimension = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorActuel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToucheControl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nsommet = new System.Windows.Forms.ToolStripStatusLabel();
            this.choississez = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripMenuItem();
            this.réglageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeSegemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.PrintPage = new System.Drawing.Printing.PrintDocument();
            this.PrintApercu = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AjusterPage = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ToolCarre = new System.Windows.Forms.ToolStripButton();
            this.toolCercle = new System.Windows.Forms.ToolStripButton();
            this.toolpolygonecercle = new System.Windows.Forms.ToolStripButton();
            this.Rosace = new System.Windows.Forms.ToolStripButton();
            this.polygone = new System.Windows.Forms.ToolStripButton();
            this.toolClear = new System.Windows.Forms.ToolStripButton();
            this.toolprint = new System.Windows.Forms.ToolStripButton();
            this.centerH = new System.Windows.Forms.CheckBox();
            this.centerV = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.choississez.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripForm,
            this.toolStripPostion,
            this.toolStripStatusLabel2,
            this.toolStripDimension,
            this.colorActuel,
            this.ToucheControl,
            this.toolStripStatusLabel1,
            this.nsommet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripForm
            // 
            this.toolStripForm.AutoSize = false;
            this.toolStripForm.Name = "toolStripForm";
            this.toolStripForm.Size = new System.Drawing.Size(100, 17);
            this.toolStripForm.Text = "pas de forme";
            // 
            // toolStripPostion
            // 
            this.toolStripPostion.Name = "toolStripPostion";
            this.toolStripPostion.Size = new System.Drawing.Size(112, 17);
            this.toolStripPostion.Text = "Postion: (0000:0000)";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel2.Text = "Dimension:";
            // 
            // toolStripDimension
            // 
            this.toolStripDimension.Name = "toolStripDimension";
            this.toolStripDimension.Size = new System.Drawing.Size(66, 17);
            this.toolStripDimension.Text = "(0000:0000)";
            // 
            // colorActuel
            // 
            this.colorActuel.BackColor = System.Drawing.Color.Black;
            this.colorActuel.Name = "colorActuel";
            this.colorActuel.Size = new System.Drawing.Size(34, 17);
            this.colorActuel.Text = "         ";
            // 
            // ToucheControl
            // 
            this.ToucheControl.AutoSize = false;
            this.ToucheControl.Name = "ToucheControl";
            this.ToucheControl.Size = new System.Drawing.Size(100, 17);
            this.ToucheControl.Text = "not key Control";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "N sommet:";
            // 
            // nsommet
            // 
            this.nsommet.Name = "nsommet";
            this.nsommet.Size = new System.Drawing.Size(19, 17);
            this.nsommet.Text = "18";
            // 
            // choississez
            // 
            this.choississez.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox6,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripTextBox4,
            this.réglageToolStripMenuItem});
            this.choississez.Name = "contextMenuStrip1";
            this.choississez.Size = new System.Drawing.Size(117, 136);
            this.choississez.Text = "choississez";
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.BackColor = System.Drawing.Color.Black;
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(116, 22);
            this.toolStripTextBox6.Click += new System.EventHandler(this.toolChoixColor_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(116, 22);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolChoixColor_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(116, 22);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolChoixColor_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BackColor = System.Drawing.Color.Chocolate;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(116, 22);
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolChoixColor_Click);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.BackColor = System.Drawing.Color.Green;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(116, 22);
            this.toolStripTextBox4.Click += new System.EventHandler(this.toolChoixColor_Click);
            // 
            // réglageToolStripMenuItem
            // 
            this.réglageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeSegemntToolStripMenuItem});
            this.réglageToolStripMenuItem.Name = "réglageToolStripMenuItem";
            this.réglageToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.réglageToolStripMenuItem.Text = "Réglage";
            // 
            // nombreDeSegemntToolStripMenuItem
            // 
            this.nombreDeSegemntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.nombreDeSegemntToolStripMenuItem.Name = "nombreDeSegemntToolStripMenuItem";
            this.nombreDeSegemntToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nombreDeSegemntToolStripMenuItem.Text = "nombre de segments";
            this.nombreDeSegemntToolStripMenuItem.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "4";
            this.toolStripMenuItem2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "8";
            this.toolStripMenuItem3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "16";
            this.toolStripMenuItem4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "18";
            this.toolStripMenuItem5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem5.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "20";
            this.toolStripMenuItem6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem6.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "32";
            this.toolStripMenuItem7.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem7.Click += new System.EventHandler(this.nombreDeSegemnt_Click);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 23);
            // 
            // PrintDialog
            // 
            this.PrintDialog.Document = this.PrintPage;
            this.PrintDialog.UseEXDialog = true;
            // 
            // PrintPage
            // 
            this.PrintPage.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage_PrintPage);
            // 
            // PrintApercu
            // 
            this.PrintApercu.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintApercu.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintApercu.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintApercu.Enabled = true;
            this.PrintApercu.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintApercu.Icon")));
            this.PrintApercu.Name = "PrintApercu";
            this.PrintApercu.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCarre,
            this.toolCercle,
            this.toolpolygonecercle,
            this.Rosace,
            this.polygone,
            this.toolClear,
            this.toolprint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 55);
            this.toolStrip1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 160);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 160);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dessin_KeyDown);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dessin_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.centerV);
            this.panel2.Controls.Add(this.centerH);
            this.panel2.Controls.Add(this.AjusterPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(538, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 160);
            this.panel2.TabIndex = 0;
            // 
            // AjusterPage
            // 
            this.AjusterPage.AutoSize = true;
            this.AjusterPage.Location = new System.Drawing.Point(15, 17);
            this.AjusterPage.Name = "AjusterPage";
            this.AjusterPage.Size = new System.Drawing.Size(105, 17);
            this.AjusterPage.TabIndex = 0;
            this.AjusterPage.Text = "Ajuster à la page";
            this.AjusterPage.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 321);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(738, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // ToolCarre
            // 
            this.ToolCarre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCarre.Image = global::print.Properties.Resources.Image2;
            this.ToolCarre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCarre.Name = "ToolCarre";
            this.ToolCarre.Size = new System.Drawing.Size(52, 52);
            this.ToolCarre.Text = "Carree";
            this.ToolCarre.Click += new System.EventHandler(this.tool_Click);
            // 
            // toolCercle
            // 
            this.toolCercle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCercle.Image = global::print.Properties.Resources.unite_cercle;
            this.toolCercle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCercle.Name = "toolCercle";
            this.toolCercle.Size = new System.Drawing.Size(52, 52);
            this.toolCercle.Text = "Cercle";
            this.toolCercle.Click += new System.EventHandler(this.tool_Click);
            // 
            // toolpolygonecercle
            // 
            this.toolpolygonecercle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolpolygonecercle.Image = global::print.Properties.Resources.polygone_18_cotes;
            this.toolpolygonecercle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolpolygonecercle.Name = "toolpolygonecercle";
            this.toolpolygonecercle.Size = new System.Drawing.Size(52, 52);
            this.toolpolygonecercle.Text = "Polygone cercle";
            this.toolpolygonecercle.Click += new System.EventHandler(this.tool_Click);
            // 
            // Rosace
            // 
            this.Rosace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rosace.Image = ((System.Drawing.Image)(resources.GetObject("Rosace.Image")));
            this.Rosace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rosace.Name = "Rosace";
            this.Rosace.Size = new System.Drawing.Size(52, 52);
            this.Rosace.Text = "Rosace";
            this.Rosace.Click += new System.EventHandler(this.tool_Click);
            // 
            // polygone
            // 
            this.polygone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.polygone.Image = global::print.Properties.Resources.Capture_poly;
            this.polygone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polygone.Name = "polygone";
            this.polygone.Size = new System.Drawing.Size(52, 52);
            this.polygone.Text = "Polygone";
            this.polygone.Click += new System.EventHandler(this.tool_Click);
            // 
            // toolClear
            // 
            this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolClear.Image = ((System.Drawing.Image)(resources.GetObject("toolClear.Image")));
            this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClear.Name = "toolClear";
            this.toolClear.Size = new System.Drawing.Size(38, 52);
            this.toolClear.Text = "Clear";
            this.toolClear.Click += new System.EventHandler(this.toolClear_Click);
            // 
            // toolprint
            // 
            this.toolprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolprint.Image = ((System.Drawing.Image)(resources.GetObject("toolprint.Image")));
            this.toolprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolprint.Name = "toolprint";
            this.toolprint.Size = new System.Drawing.Size(36, 52);
            this.toolprint.Text = "Print";
            this.toolprint.Click += new System.EventHandler(this.toolprint_Click);
            // 
            // centerH
            // 
            this.centerH.AutoSize = true;
            this.centerH.Location = new System.Drawing.Point(15, 41);
            this.centerH.Name = "centerH";
            this.centerH.Size = new System.Drawing.Size(137, 17);
            this.centerH.TabIndex = 1;
            this.centerH.Text = "Centrer horizontalement";
            this.centerH.UseVisualStyleBackColor = true;
            // 
            // centerV
            // 
            this.centerV.AutoSize = true;
            this.centerV.Location = new System.Drawing.Point(15, 64);
            this.centerV.Name = "centerV";
            this.centerV.Size = new System.Drawing.Size(126, 17);
            this.centerV.TabIndex = 2;
            this.centerV.Text = "Centrer verticalement";
            this.centerV.UseVisualStyleBackColor = true;
            // 
            // dessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 506);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "dessin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dessin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dessin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.dessin_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dessin_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dessin_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dessin_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.choississez.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPostion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDimension;
        private System.Windows.Forms.ContextMenuStrip choississez;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        public System.Windows.Forms.ToolStripStatusLabel colorActuel;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox6;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox4;
        private System.Windows.Forms.ToolStripStatusLabel ToucheControl;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Drawing.Printing.PrintDocument PrintPage;
        private System.Windows.Forms.PrintPreviewDialog PrintApercu;
        private System.Windows.Forms.ToolStripMenuItem réglageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeSegemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripButton ToolCarre;
        private System.Windows.Forms.ToolStripButton toolCercle;
        private System.Windows.Forms.ToolStripButton toolpolygonecercle;
        private System.Windows.Forms.ToolStripButton toolClear;
        private System.Windows.Forms.ToolStripButton toolprint;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton polygone;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nsommet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton Rosace;
        private System.Windows.Forms.CheckBox AjusterPage;
        private System.Windows.Forms.CheckBox centerV;
        private System.Windows.Forms.CheckBox centerH;
    }
}