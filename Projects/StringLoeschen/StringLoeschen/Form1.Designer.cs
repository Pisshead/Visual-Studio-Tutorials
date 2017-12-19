namespace StringLoeschen
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
            this.LblZeichen = new System.Windows.Forms.Label();
            this.NumAnzahl = new System.Windows.Forms.NumericUpDown();
            this.LblPosition = new System.Windows.Forms.Label();
            this.NumPosition = new System.Windows.Forms.NumericUpDown();
            this.LblLoeschen = new System.Windows.Forms.Label();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // LblZeichen
            // 
            this.LblZeichen.AutoSize = true;
            this.LblZeichen.Location = new System.Drawing.Point(118, 139);
            this.LblZeichen.Name = "LblZeichen";
            this.LblZeichen.Size = new System.Drawing.Size(46, 13);
            this.LblZeichen.TabIndex = 73;
            this.LblZeichen.Text = "Zeichen";
            // 
            // NumAnzahl
            // 
            this.NumAnzahl.Location = new System.Drawing.Point(12, 132);
            this.NumAnzahl.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumAnzahl.Name = "NumAnzahl";
            this.NumAnzahl.Size = new System.Drawing.Size(100, 20);
            this.NumAnzahl.TabIndex = 72;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(12, 155);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(62, 13);
            this.LblPosition.TabIndex = 71;
            this.LblPosition.Text = "ab Position:";
            // 
            // NumPosition
            // 
            this.NumPosition.Location = new System.Drawing.Point(12, 171);
            this.NumPosition.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumPosition.Name = "NumPosition";
            this.NumPosition.Size = new System.Drawing.Size(100, 20);
            this.NumPosition.TabIndex = 70;
            this.NumPosition.ValueChanged += new System.EventHandler(this.NumPosition_ValueChanged);
            // 
            // LblLoeschen
            // 
            this.LblLoeschen.AutoSize = true;
            this.LblLoeschen.Location = new System.Drawing.Point(12, 116);
            this.LblLoeschen.Name = "LblLoeschen";
            this.LblLoeschen.Size = new System.Drawing.Size(45, 13);
            this.LblLoeschen.TabIndex = 69;
            this.LblLoeschen.Text = "Lösche:";
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(12, 9);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 68;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 61);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 67;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(12, 197);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 66;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 25);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(150, 20);
            this.TxtEingabe.TabIndex = 65;
            this.TxtEingabe.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblZeichen);
            this.Controls.Add(this.NumAnzahl);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.NumPosition);
            this.Controls.Add(this.LblLoeschen);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Löschen";
            ((System.ComponentModel.ISupportInitialize)(this.NumAnzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblZeichen;
        internal System.Windows.Forms.NumericUpDown NumAnzahl;
        internal System.Windows.Forms.Label LblPosition;
        internal System.Windows.Forms.NumericUpDown NumPosition;
        internal System.Windows.Forms.Label LblLoeschen;
        internal System.Windows.Forms.Label LblEingabe;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdLoeschen;
        internal System.Windows.Forms.TextBox TxtEingabe;
    }
}

