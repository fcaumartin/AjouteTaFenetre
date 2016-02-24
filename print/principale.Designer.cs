namespace print
{
    partial class principale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDessinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduireTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermeTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fenêtreToolStripMenuItem,
            this.dispositionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDessinToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fenêtreToolStripMenuItem.Text = "fenêtre";
            // 
            // nouveauDessinToolStripMenuItem
            // 
            this.nouveauDessinToolStripMenuItem.Name = "nouveauDessinToolStripMenuItem";
            this.nouveauDessinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.nouveauDessinToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.nouveauDessinToolStripMenuItem.Text = "exemple impression dessin";
            this.nouveauDessinToolStripMenuItem.Click += new System.EventHandler(this.nouveauDessinToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.toolStripMenuItem1.Text = "exemple impression texte";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // dispositionToolStripMenuItem
            // 
            this.dispositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.reduireTousToolStripMenuItem,
            this.fermeTousToolStripMenuItem});
            this.dispositionToolStripMenuItem.Name = "dispositionToolStripMenuItem";
            this.dispositionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dispositionToolStripMenuItem.Text = "disposition";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cascadeToolStripMenuItem.Text = "cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.PositionToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.PositionToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tileVerticalToolStripMenuItem.Text = "TileVertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.PositionToolStripMenuItem_Click);
            // 
            // reduireTousToolStripMenuItem
            // 
            this.reduireTousToolStripMenuItem.Name = "reduireTousToolStripMenuItem";
            this.reduireTousToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.reduireTousToolStripMenuItem.Text = "reduire tous";
            this.reduireTousToolStripMenuItem.Click += new System.EventHandler(this.reduireTousToolStripMenuItem_Click);
            // 
            // fermeTousToolStripMenuItem
            // 
            this.fermeTousToolStripMenuItem.Name = "fermeTousToolStripMenuItem";
            this.fermeTousToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fermeTousToolStripMenuItem.Text = "ferme tous";
            this.fermeTousToolStripMenuItem.Click += new System.EventHandler(this.fermeTousToolStripMenuItem_Click);
            // 
            // principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 539);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "principale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDessinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dispositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduireTousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermeTousToolStripMenuItem;
    }
}