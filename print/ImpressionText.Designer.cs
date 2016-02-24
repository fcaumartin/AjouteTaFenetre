namespace print
{
    partial class ImpressionText
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpressionText));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PageImpression = new System.Drawing.Printing.PrintDocument();
            this.ApercuImpression = new System.Windows.Forms.PrintPreviewDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Print = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PageImpression
            // 
            this.PageImpression.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PageImpression_PrintPage);
            // 
            // ApercuImpression
            // 
            this.ApercuImpression.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ApercuImpression.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ApercuImpression.ClientSize = new System.Drawing.Size(400, 300);
            this.ApercuImpression.Enabled = true;
            this.ApercuImpression.Icon = ((System.Drawing.Icon)(resources.GetObject("ApercuImpression.Icon")));
            this.ApercuImpression.Name = "printPreviewDialog1";
            this.ApercuImpression.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(84, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 420);
            this.listBox1.TabIndex = 0;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(283, 30);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(292, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(567, 284);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // ImpressionText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImpressionText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImpressionText";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument PageImpression;
        private System.Windows.Forms.PrintPreviewDialog ApercuImpression;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ListView listView1;
    }
}

