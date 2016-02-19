namespace AjouteTaFenetre
{
    partial class Dovah
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
            this.B_ok = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.TextBox();
            this.l7 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.TextBox();
            this.tb_lettre = new System.Windows.Forms.TextBox();
            this.PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LTAP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // B_ok
            // 
            this.B_ok.Location = new System.Drawing.Point(212, 285);
            this.B_ok.Name = "B_ok";
            this.B_ok.Size = new System.Drawing.Size(123, 29);
            this.B_ok.TabIndex = 0;
            this.B_ok.Text = "OK";
            this.B_ok.UseVisualStyleBackColor = true;
            this.B_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1
            // 
            this.l1.Enabled = false;
            this.l1.Location = new System.Drawing.Point(22, 28);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(60, 20);
            this.l1.TabIndex = 1;
            // 
            // l2
            // 
            this.l2.Enabled = false;
            this.l2.Location = new System.Drawing.Point(96, 28);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(60, 20);
            this.l2.TabIndex = 2;
            // 
            // l7
            // 
            this.l7.Enabled = false;
            this.l7.Location = new System.Drawing.Point(466, 28);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(60, 20);
            this.l7.TabIndex = 3;
            // 
            // l6
            // 
            this.l6.Enabled = false;
            this.l6.Location = new System.Drawing.Point(392, 28);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(60, 20);
            this.l6.TabIndex = 4;
            // 
            // l5
            // 
            this.l5.Enabled = false;
            this.l5.Location = new System.Drawing.Point(318, 28);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(60, 20);
            this.l5.TabIndex = 5;
            // 
            // l4
            // 
            this.l4.Enabled = false;
            this.l4.Location = new System.Drawing.Point(244, 28);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(60, 20);
            this.l4.TabIndex = 6;
            // 
            // l3
            // 
            this.l3.Enabled = false;
            this.l3.Location = new System.Drawing.Point(170, 28);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(60, 20);
            this.l3.TabIndex = 7;
            // 
            // tb_lettre
            // 
            this.tb_lettre.Location = new System.Drawing.Point(160, 238);
            this.tb_lettre.Name = "tb_lettre";
            this.tb_lettre.Size = new System.Drawing.Size(228, 20);
            this.tb_lettre.TabIndex = 8;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(160, 90);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(228, 128);
            this.PB.TabIndex = 9;
            this.PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entrer une lettre";
            // 
            // LTAP
            // 
            this.LTAP.AutoSize = true;
            this.LTAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTAP.Location = new System.Drawing.Point(409, 104);
            this.LTAP.Name = "LTAP";
            this.LTAP.Size = new System.Drawing.Size(0, 20);
            this.LTAP.TabIndex = 11;
            this.LTAP.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lettres saisies :";
            // 
            // Dovah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LTAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.tb_lettre);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.B_ok);
            this.Name = "Dovah";
            this.Text = "Dovah-Pendu";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_ok;
        private System.Windows.Forms.TextBox l1;
        private System.Windows.Forms.TextBox l2;
        private System.Windows.Forms.TextBox l7;
        private System.Windows.Forms.TextBox l6;
        private System.Windows.Forms.TextBox l5;
        private System.Windows.Forms.TextBox l4;
        private System.Windows.Forms.TextBox l3;
        private System.Windows.Forms.TextBox tb_lettre;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTAP;
        public System.Windows.Forms.Label label2;
    }
}