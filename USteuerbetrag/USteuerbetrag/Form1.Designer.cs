namespace USteuerbetrag
{
    partial class FrmSteuersatz
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
            this.LblGehalt = new System.Windows.Forms.Label();
            this.CmdBerechnen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumGehalt = new System.Windows.Forms.NumericUpDown();
            this.CmdEnde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumGehalt)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGehalt
            // 
            this.LblGehalt.AutoSize = true;
            this.LblGehalt.Location = new System.Drawing.Point(12, 9);
            this.LblGehalt.Name = "LblGehalt";
            this.LblGehalt.Size = new System.Drawing.Size(41, 13);
            this.LblGehalt.TabIndex = 0;
            this.LblGehalt.Text = "Gehalt:";
            // 
            // CmdBerechnen
            // 
            this.CmdBerechnen.Location = new System.Drawing.Point(12, 107);
            this.CmdBerechnen.Name = "CmdBerechnen";
            this.CmdBerechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdBerechnen.TabIndex = 1;
            this.CmdBerechnen.Text = "Berechnen";
            this.CmdBerechnen.UseVisualStyleBackColor = true;
            this.CmdBerechnen.Click += new System.EventHandler(this.CmdBerechnen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(175, 49);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // NumGehalt
            // 
            this.NumGehalt.Location = new System.Drawing.Point(12, 47);
            this.NumGehalt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumGehalt.Name = "NumGehalt";
            this.NumGehalt.Size = new System.Drawing.Size(120, 20);
            this.NumGehalt.TabIndex = 3;
            this.NumGehalt.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmSteuersatz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.NumGehalt);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdBerechnen);
            this.Controls.Add(this.LblGehalt);
            this.Name = "FrmSteuersatz";
            this.Text = "Steuersatz";
            ((System.ComponentModel.ISupportInitialize)(this.NumGehalt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGehalt;
        private System.Windows.Forms.Button CmdBerechnen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumGehalt;
        private System.Windows.Forms.Button CmdEnde;
    }
}

