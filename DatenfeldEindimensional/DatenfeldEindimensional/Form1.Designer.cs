namespace DatenfeldEindimensional
{
    partial class FrmDatenfeldEindimensional
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
            this.LstDaten = new System.Windows.Forms.ListBox();
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstDaten
            // 
            this.LstDaten.FormattingEnabled = true;
            this.LstDaten.Location = new System.Drawing.Point(13, 13);
            this.LstDaten.Name = "LstDaten";
            this.LstDaten.Size = new System.Drawing.Size(120, 238);
            this.LstDaten.TabIndex = 0;
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(342, 13);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen1.TabIndex = 1;
            this.CmdAnzeigen1.Text = "Anzeigen 1";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(342, 43);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen2.TabIndex = 2;
            this.CmdAnzeigen2.Text = "Anzeigen 2";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(342, 73);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen3.TabIndex = 3;
            this.CmdAnzeigen3.Text = "Anzeigen 3";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(342, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(139, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 5;
            // 
            // FrmDatenfeldEindimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Controls.Add(this.LstDaten);
            this.Name = "FrmDatenfeldEindimensional";
            this.Text = "Eindimensionales Datenfeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstDaten;
        private System.Windows.Forms.Button CmdAnzeigen1;
        private System.Windows.Forms.Button CmdAnzeigen2;
        private System.Windows.Forms.Button CmdAnzeigen3;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

