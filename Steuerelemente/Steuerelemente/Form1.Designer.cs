namespace Steuerelemente
{
    partial class FrmPosGrFrb
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
            this.CmdPosRel = new System.Windows.Forms.Button();
            this.CmdGrAbs = new System.Windows.Forms.Button();
            this.CmdPosAbs = new System.Windows.Forms.Button();
            this.CmdTest = new System.Windows.Forms.Button();
            this.CmdGrRel = new System.Windows.Forms.Button();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdFrb = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPosRel
            // 
            this.CmdPosRel.Location = new System.Drawing.Point(40, 25);
            this.CmdPosRel.Name = "CmdPosRel";
            this.CmdPosRel.Size = new System.Drawing.Size(75, 35);
            this.CmdPosRel.TabIndex = 0;
            this.CmdPosRel.Text = "Relative Position";
            this.CmdPosRel.UseVisualStyleBackColor = true;
            this.CmdPosRel.Click += new System.EventHandler(this.CmdPosRel_Click);
            // 
            // CmdGrAbs
            // 
            this.CmdGrAbs.Location = new System.Drawing.Point(179, 90);
            this.CmdGrAbs.Name = "CmdGrAbs";
            this.CmdGrAbs.Size = new System.Drawing.Size(75, 34);
            this.CmdGrAbs.TabIndex = 1;
            this.CmdGrAbs.Text = "Absolute Grösse";
            this.CmdGrAbs.UseVisualStyleBackColor = true;
            this.CmdGrAbs.Click += new System.EventHandler(this.CmdGrAbs_Click);
            // 
            // CmdPosAbs
            // 
            this.CmdPosAbs.Location = new System.Drawing.Point(179, 25);
            this.CmdPosAbs.Name = "CmdPosAbs";
            this.CmdPosAbs.Size = new System.Drawing.Size(75, 35);
            this.CmdPosAbs.TabIndex = 2;
            this.CmdPosAbs.Text = "Absolute Position";
            this.CmdPosAbs.UseVisualStyleBackColor = true;
            this.CmdPosAbs.Click += new System.EventHandler(this.CmdPosAbs_Click);
            // 
            // CmdTest
            // 
            this.CmdTest.Location = new System.Drawing.Point(40, 167);
            this.CmdTest.Name = "CmdTest";
            this.CmdTest.Size = new System.Drawing.Size(75, 23);
            this.CmdTest.TabIndex = 3;
            this.CmdTest.Text = "Test";
            this.CmdTest.UseVisualStyleBackColor = true;
            // 
            // CmdGrRel
            // 
            this.CmdGrRel.Location = new System.Drawing.Point(40, 90);
            this.CmdGrRel.Name = "CmdGrRel";
            this.CmdGrRel.Size = new System.Drawing.Size(75, 34);
            this.CmdGrRel.TabIndex = 4;
            this.CmdGrRel.Text = "Relative Grösse";
            this.CmdGrRel.UseVisualStyleBackColor = true;
            this.CmdGrRel.Click += new System.EventHandler(this.CmdGrRel_Click);
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(318, 25);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 5;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(315, 167);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 6;
            // 
            // CmdFrb
            // 
            this.CmdFrb.Location = new System.Drawing.Point(318, 90);
            this.CmdFrb.Name = "CmdFrb";
            this.CmdFrb.Size = new System.Drawing.Size(75, 23);
            this.CmdFrb.TabIndex = 7;
            this.CmdFrb.Text = "Farbe";
            this.CmdFrb.UseVisualStyleBackColor = true;
            this.CmdFrb.Click += new System.EventHandler(this.CmdFrb_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(318, 302);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 8;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPosGrFrb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdFrb);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.CmdGrRel);
            this.Controls.Add(this.CmdTest);
            this.Controls.Add(this.CmdPosAbs);
            this.Controls.Add(this.CmdGrAbs);
            this.Controls.Add(this.CmdPosRel);
            this.Name = "FrmPosGrFrb";
            this.Text = "Position, Grösse, Farbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPosRel;
        private System.Windows.Forms.Button CmdGrAbs;
        private System.Windows.Forms.Button CmdPosAbs;
        private System.Windows.Forms.Button CmdTest;
        private System.Windows.Forms.Button CmdGrRel;
        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdFrb;
        private System.Windows.Forms.Button CmdEnde;
    }
}

