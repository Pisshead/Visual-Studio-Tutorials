namespace ZeichnenGrundformen
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
            this.ChkFuellen = new System.Windows.Forms.CheckBox();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdLinie = new System.Windows.Forms.Button();
            this.CmdEllipse = new System.Windows.Forms.Button();
            this.LstFarbe = new System.Windows.Forms.ListBox();
            this.LblFarbe = new System.Windows.Forms.Label();
            this.LblDicke = new System.Windows.Forms.Label();
            this.NumPenWidth = new System.Windows.Forms.NumericUpDown();
            this.CmdPolygon = new System.Windows.Forms.Button();
            this.CmdRechteck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkFuellen
            // 
            this.ChkFuellen.AutoSize = true;
            this.ChkFuellen.Location = new System.Drawing.Point(14, 235);
            this.ChkFuellen.Name = "ChkFuellen";
            this.ChkFuellen.Size = new System.Drawing.Size(54, 17);
            this.ChkFuellen.TabIndex = 59;
            this.ChkFuellen.Text = "Füllen";
            this.ChkFuellen.UseVisualStyleBackColor = true;
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(227, 231);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 58;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdLinie
            // 
            this.CmdLinie.Location = new System.Drawing.Point(227, 12);
            this.CmdLinie.Name = "CmdLinie";
            this.CmdLinie.Size = new System.Drawing.Size(75, 23);
            this.CmdLinie.TabIndex = 57;
            this.CmdLinie.Text = "Linie";
            this.CmdLinie.UseVisualStyleBackColor = true;
            this.CmdLinie.Click += new System.EventHandler(this.CmdLinie_Click);
            // 
            // CmdEllipse
            // 
            this.CmdEllipse.Location = new System.Drawing.Point(227, 99);
            this.CmdEllipse.Name = "CmdEllipse";
            this.CmdEllipse.Size = new System.Drawing.Size(75, 23);
            this.CmdEllipse.TabIndex = 56;
            this.CmdEllipse.Text = "Ellipse";
            this.CmdEllipse.UseVisualStyleBackColor = true;
            this.CmdEllipse.Click += new System.EventHandler(this.CmdEllipse_Click);
            // 
            // LstFarbe
            // 
            this.LstFarbe.FormattingEnabled = true;
            this.LstFarbe.Location = new System.Drawing.Point(227, 180);
            this.LstFarbe.Name = "LstFarbe";
            this.LstFarbe.Size = new System.Drawing.Size(75, 43);
            this.LstFarbe.TabIndex = 55;
            this.LstFarbe.SelectedIndexChanged += new System.EventHandler(this.LstFarbe_SelectedIndexChanged);
            // 
            // LblFarbe
            // 
            this.LblFarbe.AutoSize = true;
            this.LblFarbe.Location = new System.Drawing.Point(227, 164);
            this.LblFarbe.Name = "LblFarbe";
            this.LblFarbe.Size = new System.Drawing.Size(37, 13);
            this.LblFarbe.TabIndex = 54;
            this.LblFarbe.Text = "Farbe:";
            // 
            // LblDicke
            // 
            this.LblDicke.AutoSize = true;
            this.LblDicke.Location = new System.Drawing.Point(226, 125);
            this.LblDicke.Name = "LblDicke";
            this.LblDicke.Size = new System.Drawing.Size(38, 13);
            this.LblDicke.TabIndex = 53;
            this.LblDicke.Text = "Dicke:";
            // 
            // NumPenWidth
            // 
            this.NumPenWidth.Location = new System.Drawing.Point(227, 141);
            this.NumPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumPenWidth.Name = "NumPenWidth";
            this.NumPenWidth.Size = new System.Drawing.Size(75, 20);
            this.NumPenWidth.TabIndex = 52;
            this.NumPenWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumPenWidth.ValueChanged += new System.EventHandler(this.NumPenWidth_ValueChanged);
            // 
            // CmdPolygon
            // 
            this.CmdPolygon.Location = new System.Drawing.Point(227, 70);
            this.CmdPolygon.Name = "CmdPolygon";
            this.CmdPolygon.Size = new System.Drawing.Size(75, 23);
            this.CmdPolygon.TabIndex = 51;
            this.CmdPolygon.Text = "Polygon";
            this.CmdPolygon.UseVisualStyleBackColor = true;
            this.CmdPolygon.Click += new System.EventHandler(this.CmdPolygon_Click);
            // 
            // CmdRechteck
            // 
            this.CmdRechteck.Location = new System.Drawing.Point(227, 41);
            this.CmdRechteck.Name = "CmdRechteck";
            this.CmdRechteck.Size = new System.Drawing.Size(75, 23);
            this.CmdRechteck.TabIndex = 50;
            this.CmdRechteck.Text = "Rechteck";
            this.CmdRechteck.UseVisualStyleBackColor = true;
            this.CmdRechteck.Click += new System.EventHandler(this.CmdRechteck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 271);
            this.Controls.Add(this.ChkFuellen);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdLinie);
            this.Controls.Add(this.CmdEllipse);
            this.Controls.Add(this.LstFarbe);
            this.Controls.Add(this.LblFarbe);
            this.Controls.Add(this.LblDicke);
            this.Controls.Add(this.NumPenWidth);
            this.Controls.Add(this.CmdPolygon);
            this.Controls.Add(this.CmdRechteck);
            this.Name = "Form1";
            this.Text = "Zeichnen, Grundformen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox ChkFuellen;
        internal System.Windows.Forms.Button CmdLoeschen;
        internal System.Windows.Forms.Button CmdLinie;
        internal System.Windows.Forms.Button CmdEllipse;
        internal System.Windows.Forms.ListBox LstFarbe;
        internal System.Windows.Forms.Label LblFarbe;
        internal System.Windows.Forms.Label LblDicke;
        internal System.Windows.Forms.NumericUpDown NumPenWidth;
        internal System.Windows.Forms.Button CmdPolygon;
        internal System.Windows.Forms.Button CmdRechteck;
    }
}

