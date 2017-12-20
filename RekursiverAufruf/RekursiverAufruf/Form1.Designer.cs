namespace RekursiverAufruf
{
    partial class FrmRekursiverAufruf
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
            this.CmdRekursion = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdSchleife = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdRekursion
            // 
            this.CmdRekursion.Location = new System.Drawing.Point(197, 42);
            this.CmdRekursion.Name = "CmdRekursion";
            this.CmdRekursion.Size = new System.Drawing.Size(75, 23);
            this.CmdRekursion.TabIndex = 0;
            this.CmdRekursion.Text = "Rekursion";
            this.CmdRekursion.UseVisualStyleBackColor = true;
            this.CmdRekursion.Click += new System.EventHandler(this.CmdRekursion_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 1;
            // 
            // CmdSchleife
            // 
            this.CmdSchleife.Location = new System.Drawing.Point(197, 13);
            this.CmdSchleife.Name = "CmdSchleife";
            this.CmdSchleife.Size = new System.Drawing.Size(75, 23);
            this.CmdSchleife.TabIndex = 2;
            this.CmdSchleife.Text = "Schleife";
            this.CmdSchleife.UseVisualStyleBackColor = true;
            this.CmdSchleife.Click += new System.EventHandler(this.CmdSchleife_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 3;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmRekursiverAufruf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdSchleife);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdRekursion);
            this.Name = "FrmRekursiverAufruf";
            this.Text = "Rekursiver Aufruf einer Methode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdRekursion;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdSchleife;
        private System.Windows.Forms.Button CmdEnde;
    }
}

