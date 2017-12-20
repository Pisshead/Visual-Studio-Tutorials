namespace UDatenfeldEindimensional
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
            this.LstBoxRandom = new System.Windows.Forms.ListBox();
            this.CmdMinima = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdGenerieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxRandom
            // 
            this.LstBoxRandom.FormattingEnabled = true;
            this.LstBoxRandom.Location = new System.Drawing.Point(13, 13);
            this.LstBoxRandom.Name = "LstBoxRandom";
            this.LstBoxRandom.Size = new System.Drawing.Size(78, 238);
            this.LstBoxRandom.TabIndex = 0;
            // 
            // CmdMinima
            // 
            this.CmdMinima.Location = new System.Drawing.Point(197, 42);
            this.CmdMinima.Name = "CmdMinima";
            this.CmdMinima.Size = new System.Drawing.Size(75, 23);
            this.CmdMinima.TabIndex = 1;
            this.CmdMinima.Text = "Minima";
            this.CmdMinima.UseVisualStyleBackColor = true;
            this.CmdMinima.Click += new System.EventHandler(this.CmdMinima_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(194, 66);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 3;
            // 
            // CmdGenerieren
            // 
            this.CmdGenerieren.Location = new System.Drawing.Point(197, 13);
            this.CmdGenerieren.Name = "CmdGenerieren";
            this.CmdGenerieren.Size = new System.Drawing.Size(75, 23);
            this.CmdGenerieren.TabIndex = 4;
            this.CmdGenerieren.Text = "Generieren";
            this.CmdGenerieren.UseVisualStyleBackColor = true;
            this.CmdGenerieren.Click += new System.EventHandler(this.CmdGenerieren_Click);
            // 
            // FrmDatenfeldEindimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 261);
            this.Controls.Add(this.CmdGenerieren);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdMinima);
            this.Controls.Add(this.LstBoxRandom);
            this.Name = "FrmDatenfeldEindimensional";
            this.Text = "Datenfeld eindimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxRandom;
        private System.Windows.Forms.Button CmdMinima;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdGenerieren;
    }
}

