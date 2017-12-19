namespace MethodenUebergabe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdDreiDimFeld = new System.Windows.Forms.Button();
            this.CmdOut = new System.Windows.Forms.Button();
            this.CmdEinDimFeld = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdReferenz = new System.Windows.Forms.Button();
            this.CmdKopie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdDreiDimFeld
            // 
            this.CmdDreiDimFeld.Location = new System.Drawing.Point(182, 99);
            this.CmdDreiDimFeld.Name = "CmdDreiDimFeld";
            this.CmdDreiDimFeld.Size = new System.Drawing.Size(90, 23);
            this.CmdDreiDimFeld.TabIndex = 28;
            this.CmdDreiDimFeld.Text = "dreidim. Feld";
            this.CmdDreiDimFeld.UseVisualStyleBackColor = true;
            this.CmdDreiDimFeld.Click += new System.EventHandler(this.CmdDreiDimFeld_Click);
            // 
            // CmdOut
            // 
            this.CmdOut.Location = new System.Drawing.Point(182, 128);
            this.CmdOut.Name = "CmdOut";
            this.CmdOut.Size = new System.Drawing.Size(90, 23);
            this.CmdOut.TabIndex = 27;
            this.CmdOut.Text = "out";
            this.CmdOut.UseVisualStyleBackColor = true;
            this.CmdOut.Click += new System.EventHandler(this.CmdOut_Click);
            // 
            // CmdEinDimFeld
            // 
            this.CmdEinDimFeld.Location = new System.Drawing.Point(182, 70);
            this.CmdEinDimFeld.Name = "CmdEinDimFeld";
            this.CmdEinDimFeld.Size = new System.Drawing.Size(90, 23);
            this.CmdEinDimFeld.TabIndex = 26;
            this.CmdEinDimFeld.Text = "eindim. Feld";
            this.CmdEinDimFeld.UseVisualStyleBackColor = true;
            this.CmdEinDimFeld.Click += new System.EventHandler(this.CmdEinDimFeld_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(16, 17);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 25;
            // 
            // CmdReferenz
            // 
            this.CmdReferenz.Location = new System.Drawing.Point(182, 41);
            this.CmdReferenz.Name = "CmdReferenz";
            this.CmdReferenz.Size = new System.Drawing.Size(90, 23);
            this.CmdReferenz.TabIndex = 24;
            this.CmdReferenz.Text = "Referenz";
            this.CmdReferenz.UseVisualStyleBackColor = true;
            this.CmdReferenz.Click += new System.EventHandler(this.CmdReferenz_Click);
            // 
            // CmdKopie
            // 
            this.CmdKopie.Location = new System.Drawing.Point(182, 12);
            this.CmdKopie.Name = "CmdKopie";
            this.CmdKopie.Size = new System.Drawing.Size(90, 23);
            this.CmdKopie.TabIndex = 23;
            this.CmdKopie.Text = "Kopie";
            this.CmdKopie.UseVisualStyleBackColor = true;
            this.CmdKopie.Click += new System.EventHandler(this.CmdKopie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdDreiDimFeld);
            this.Controls.Add(this.CmdOut);
            this.Controls.Add(this.CmdEinDimFeld);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdReferenz);
            this.Controls.Add(this.CmdKopie);
            this.Name = "Form1";
            this.Text = "Übergabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdDreiDimFeld;
        internal System.Windows.Forms.Button CmdOut;
        internal System.Windows.Forms.Button CmdEinDimFeld;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdReferenz;
        internal System.Windows.Forms.Button CmdKopie;
    }
}

