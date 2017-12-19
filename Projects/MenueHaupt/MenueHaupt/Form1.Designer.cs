namespace MenueHaupt
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.MnuKursiv = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFett = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CboSchriftgroesse = new System.Windows.Forms.ToolStripComboBox();
            this.MnuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSchriftart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuRot = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBlau = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGelb = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHintergrund = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAnsicht = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnde = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKopieren = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHaupt = new System.Windows.Forms.MenuStrip();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.MnuHaupt.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 165);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 20;
            // 
            // MnuKursiv
            // 
            this.MnuKursiv.Name = "MnuKursiv";
            this.MnuKursiv.Size = new System.Drawing.Size(181, 22);
            this.MnuKursiv.Text = "Kursiv";
            this.MnuKursiv.Click += new System.EventHandler(this.MnuKursiv_Click);
            // 
            // MnuFett
            // 
            this.MnuFett.Name = "MnuFett";
            this.MnuFett.Size = new System.Drawing.Size(181, 22);
            this.MnuFett.Text = "Fett";
            this.MnuFett.Click += new System.EventHandler(this.MnuFett_Click);
            // 
            // MnuSeparator2
            // 
            this.MnuSeparator2.Name = "MnuSeparator2";
            this.MnuSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // CboSchriftgroesse
            // 
            this.CboSchriftgroesse.Name = "CboSchriftgroesse";
            this.CboSchriftgroesse.Size = new System.Drawing.Size(121, 23);
            this.CboSchriftgroesse.TextChanged += new System.EventHandler(this.CboSchriftgroesse_TextChanged);
            // 
            // MnuArial
            // 
            this.MnuArial.Name = "MnuArial";
            this.MnuArial.Size = new System.Drawing.Size(140, 22);
            this.MnuArial.Text = "Arial";
            this.MnuArial.Click += new System.EventHandler(this.MnuArial_Click);
            // 
            // MnuSymbol
            // 
            this.MnuSymbol.Name = "MnuSymbol";
            this.MnuSymbol.Size = new System.Drawing.Size(140, 22);
            this.MnuSymbol.Text = "Symbol";
            this.MnuSymbol.Click += new System.EventHandler(this.MnuSymbol_Click);
            // 
            // MnuCourierNew
            // 
            this.MnuCourierNew.Checked = true;
            this.MnuCourierNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuCourierNew.Name = "MnuCourierNew";
            this.MnuCourierNew.Size = new System.Drawing.Size(140, 22);
            this.MnuCourierNew.Text = "Courier New";
            this.MnuCourierNew.Click += new System.EventHandler(this.MnuCourierNew_Click);
            // 
            // MnuSchriftart
            // 
            this.MnuSchriftart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCourierNew,
            this.MnuSymbol,
            this.MnuArial});
            this.MnuSchriftart.Name = "MnuSchriftart";
            this.MnuSchriftart.Size = new System.Drawing.Size(181, 22);
            this.MnuSchriftart.Text = "Schriftart";
            // 
            // MnuSeparator1
            // 
            this.MnuSeparator1.Name = "MnuSeparator1";
            this.MnuSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // MnuRot
            // 
            this.MnuRot.Name = "MnuRot";
            this.MnuRot.Size = new System.Drawing.Size(98, 22);
            this.MnuRot.Text = "Rot";
            this.MnuRot.Click += new System.EventHandler(this.MnuRot_Click);
            // 
            // MnuBlau
            // 
            this.MnuBlau.Name = "MnuBlau";
            this.MnuBlau.Size = new System.Drawing.Size(98, 22);
            this.MnuBlau.Text = "Blau";
            this.MnuBlau.Click += new System.EventHandler(this.MnuBlau_Click);
            // 
            // MnuGelb
            // 
            this.MnuGelb.Checked = true;
            this.MnuGelb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuGelb.Name = "MnuGelb";
            this.MnuGelb.Size = new System.Drawing.Size(98, 22);
            this.MnuGelb.Text = "Gelb";
            this.MnuGelb.Click += new System.EventHandler(this.MnuGelb_Click);
            // 
            // MnuHintergrund
            // 
            this.MnuHintergrund.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGelb,
            this.MnuBlau,
            this.MnuRot});
            this.MnuHintergrund.Name = "MnuHintergrund";
            this.MnuHintergrund.Size = new System.Drawing.Size(181, 22);
            this.MnuHintergrund.Text = "Hintergrund";
            // 
            // MnuAnsicht
            // 
            this.MnuAnsicht.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHintergrund,
            this.MnuSeparator1,
            this.MnuSchriftart,
            this.CboSchriftgroesse,
            this.MnuSeparator2,
            this.MnuFett,
            this.MnuKursiv});
            this.MnuAnsicht.Name = "MnuAnsicht";
            this.MnuAnsicht.Size = new System.Drawing.Size(59, 20);
            this.MnuAnsicht.Text = "&Ansicht";
            // 
            // MnuEnde
            // 
            this.MnuEnde.Name = "MnuEnde";
            this.MnuEnde.Size = new System.Drawing.Size(121, 22);
            this.MnuEnde.Text = "&Ende";
            this.MnuEnde.Click += new System.EventHandler(this.MnuEnde_Click);
            // 
            // MnuKopieren
            // 
            this.MnuKopieren.Name = "MnuKopieren";
            this.MnuKopieren.Size = new System.Drawing.Size(121, 22);
            this.MnuKopieren.Text = "&Kopieren";
            this.MnuKopieren.Click += new System.EventHandler(this.MnuKopieren_Click);
            // 
            // MnuBearbeiten
            // 
            this.MnuBearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuKopieren,
            this.MnuEnde});
            this.MnuBearbeiten.Name = "MnuBearbeiten";
            this.MnuBearbeiten.Size = new System.Drawing.Size(75, 20);
            this.MnuBearbeiten.Text = "&Bearbeiten";
            // 
            // MnuHaupt
            // 
            this.MnuHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBearbeiten,
            this.MnuAnsicht});
            this.MnuHaupt.Location = new System.Drawing.Point(0, 0);
            this.MnuHaupt.Name = "MnuHaupt";
            this.MnuHaupt.Size = new System.Drawing.Size(284, 24);
            this.MnuHaupt.TabIndex = 19;
            this.MnuHaupt.Text = "MenuStrip1";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BackColor = System.Drawing.Color.Yellow;
            this.LblAnzeige.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnzeige.Location = new System.Drawing.Point(12, 197);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(49, 14);
            this.LblAnzeige.TabIndex = 21;
            this.LblAnzeige.Text = "(leer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.MnuHaupt);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Hauptmenü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnuHaupt.ResumeLayout(false);
            this.MnuHaupt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtEingabe;
        internal System.Windows.Forms.ToolStripMenuItem MnuKursiv;
        internal System.Windows.Forms.ToolStripMenuItem MnuFett;
        internal System.Windows.Forms.ToolStripSeparator MnuSeparator2;
        internal System.Windows.Forms.ToolStripComboBox CboSchriftgroesse;
        internal System.Windows.Forms.ToolStripMenuItem MnuArial;
        internal System.Windows.Forms.ToolStripMenuItem MnuSymbol;
        internal System.Windows.Forms.ToolStripMenuItem MnuCourierNew;
        internal System.Windows.Forms.ToolStripMenuItem MnuSchriftart;
        internal System.Windows.Forms.ToolStripSeparator MnuSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem MnuRot;
        internal System.Windows.Forms.ToolStripMenuItem MnuBlau;
        internal System.Windows.Forms.ToolStripMenuItem MnuGelb;
        internal System.Windows.Forms.ToolStripMenuItem MnuHintergrund;
        internal System.Windows.Forms.ToolStripMenuItem MnuAnsicht;
        internal System.Windows.Forms.ToolStripMenuItem MnuEnde;
        internal System.Windows.Forms.ToolStripMenuItem MnuKopieren;
        internal System.Windows.Forms.ToolStripMenuItem MnuBearbeiten;
        internal System.Windows.Forms.MenuStrip MnuHaupt;
        internal System.Windows.Forms.Label LblAnzeige;
    }
}

