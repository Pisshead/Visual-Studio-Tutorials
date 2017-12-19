namespace ZeichnenText
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
            this.LstSchriftart = new System.Windows.Forms.ListBox();
            this.LblSchriftart = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.LstFarbe = new System.Windows.Forms.ListBox();
            this.LblFarbe = new System.Windows.Forms.Label();
            this.LblSchriftgroesse = new System.Windows.Forms.Label();
            this.NumSchriftgroesse = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumSchriftgroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // LstSchriftart
            // 
            this.LstSchriftart.FormattingEnabled = true;
            this.LstSchriftart.Location = new System.Drawing.Point(207, 55);
            this.LstSchriftart.Name = "LstSchriftart";
            this.LstSchriftart.Size = new System.Drawing.Size(75, 56);
            this.LstSchriftart.TabIndex = 58;
            this.LstSchriftart.SelectedIndexChanged += new System.EventHandler(this.LstSchriftart_SelectedIndexChanged);
            // 
            // LblSchriftart
            // 
            this.LblSchriftart.AutoSize = true;
            this.LblSchriftart.Location = new System.Drawing.Point(205, 39);
            this.LblSchriftart.Name = "LblSchriftart";
            this.LblSchriftart.Size = new System.Drawing.Size(52, 13);
            this.LblSchriftart.TabIndex = 57;
            this.LblSchriftart.Text = "Schriftart:";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(14, 234);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(174, 20);
            this.TxtEingabe.TabIndex = 56;
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(207, 12);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 55;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(207, 231);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 54;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // LstFarbe
            // 
            this.LstFarbe.FormattingEnabled = true;
            this.LstFarbe.Location = new System.Drawing.Point(207, 169);
            this.LstFarbe.Name = "LstFarbe";
            this.LstFarbe.Size = new System.Drawing.Size(75, 56);
            this.LstFarbe.TabIndex = 53;
            this.LstFarbe.SelectedIndexChanged += new System.EventHandler(this.LstFarbe_SelectedIndexChanged);
            // 
            // LblFarbe
            // 
            this.LblFarbe.AutoSize = true;
            this.LblFarbe.Location = new System.Drawing.Point(205, 153);
            this.LblFarbe.Name = "LblFarbe";
            this.LblFarbe.Size = new System.Drawing.Size(37, 13);
            this.LblFarbe.TabIndex = 52;
            this.LblFarbe.Text = "Farbe:";
            // 
            // LblSchriftgroesse
            // 
            this.LblSchriftgroesse.AutoSize = true;
            this.LblSchriftgroesse.Location = new System.Drawing.Point(204, 114);
            this.LblSchriftgroesse.Name = "LblSchriftgroesse";
            this.LblSchriftgroesse.Size = new System.Drawing.Size(67, 13);
            this.LblSchriftgroesse.TabIndex = 51;
            this.LblSchriftgroesse.Text = "Schriftgröße:";
            // 
            // NumSchriftgroesse
            // 
            this.NumSchriftgroesse.Location = new System.Drawing.Point(207, 130);
            this.NumSchriftgroesse.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumSchriftgroesse.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumSchriftgroesse.Name = "NumSchriftgroesse";
            this.NumSchriftgroesse.Size = new System.Drawing.Size(75, 20);
            this.NumSchriftgroesse.TabIndex = 50;
            this.NumSchriftgroesse.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumSchriftgroesse.ValueChanged += new System.EventHandler(this.NumSchriftgroesse_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.LstSchriftart);
            this.Controls.Add(this.LblSchriftart);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.CmdAnzeigen);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.LstFarbe);
            this.Controls.Add(this.LblFarbe);
            this.Controls.Add(this.LblSchriftgroesse);
            this.Controls.Add(this.NumSchriftgroesse);
            this.Name = "Form1";
            this.Text = "Zeichnen, Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumSchriftgroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox LstSchriftart;
        internal System.Windows.Forms.Label LblSchriftart;
        internal System.Windows.Forms.TextBox TxtEingabe;
        internal System.Windows.Forms.Button CmdAnzeigen;
        internal System.Windows.Forms.Button CmdLoeschen;
        internal System.Windows.Forms.ListBox LstFarbe;
        internal System.Windows.Forms.Label LblFarbe;
        internal System.Windows.Forms.Label LblSchriftgroesse;
        internal System.Windows.Forms.NumericUpDown NumSchriftgroesse;
    }
}

