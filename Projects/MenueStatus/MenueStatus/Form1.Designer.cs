namespace MenueStatus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.ConLblMenue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ConLblFett = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKopieren = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnde = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAnsicht = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHintergrund = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGelb = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBlau = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRot = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSchriftart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.CboSchriftgroesse = new System.Windows.Forms.ToolStripComboBox();
            this.MnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFett = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKursiv = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHaupt = new System.Windows.Forms.MenuStrip();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.ConTxtMenue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ConTxtReadOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.ConTxtMultiline = new System.Windows.Forms.ToolStripMenuItem();
            this.SymHaupt = new System.Windows.Forms.ToolStrip();
            this.SymFett = new System.Windows.Forms.ToolStripButton();
            this.SymKursiv = new System.Windows.Forms.ToolStripButton();
            this.SymLblSchriftgroesse = new System.Windows.Forms.ToolStripLabel();
            this.CboSymSchriftgroesse = new System.Windows.Forms.ToolStripComboBox();
            this.StaLeiste = new System.Windows.Forms.StatusStrip();
            this.StaLabelZeit = new System.Windows.Forms.ToolStripStatusLabel();
            this.StaProgressEnde = new System.Windows.Forms.ToolStripProgressBar();
            this.TimEndezeit = new System.Windows.Forms.Timer(this.components);
            this.ConLblMenue.SuspendLayout();
            this.MnuHaupt.SuspendLayout();
            this.ConTxtMenue.SuspendLayout();
            this.SymHaupt.SuspendLayout();
            this.StaLeiste.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.BackColor = System.Drawing.Color.Yellow;
            this.LblAnzeige.ContextMenuStrip = this.ConLblMenue;
            this.LblAnzeige.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnzeige.Location = new System.Drawing.Point(12, 197);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(49, 14);
            this.LblAnzeige.TabIndex = 24;
            this.LblAnzeige.Text = "(leer)";
            // 
            // ConLblMenue
            // 
            this.ConLblMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConLblFett});
            this.ConLblMenue.Name = "conLblMenü";
            this.ConLblMenue.Size = new System.Drawing.Size(95, 26);
            // 
            // ConLblFett
            // 
            this.ConLblFett.Name = "ConLblFett";
            this.ConLblFett.Size = new System.Drawing.Size(94, 22);
            this.ConLblFett.Text = "Fett";
            this.ConLblFett.Click += new System.EventHandler(this.MnuFett_Click);
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
            // MnuKopieren
            // 
            this.MnuKopieren.Name = "MnuKopieren";
            this.MnuKopieren.Size = new System.Drawing.Size(121, 22);
            this.MnuKopieren.Text = "&Kopieren";
            this.MnuKopieren.Click += new System.EventHandler(this.MnuKopieren_Click);
            // 
            // MnuEnde
            // 
            this.MnuEnde.Name = "MnuEnde";
            this.MnuEnde.Size = new System.Drawing.Size(154, 22);
            this.MnuEnde.Text = "&Ende (in 5 Sek.)";
            this.MnuEnde.Click += new System.EventHandler(this.MnuEnde_Click);
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
            // MnuGelb
            // 
            this.MnuGelb.Checked = true;
            this.MnuGelb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuGelb.Name = "MnuGelb";
            this.MnuGelb.Size = new System.Drawing.Size(98, 22);
            this.MnuGelb.Text = "Gelb";
            this.MnuGelb.Click += new System.EventHandler(this.MnuGelb_Click);
            // 
            // MnuBlau
            // 
            this.MnuBlau.Name = "MnuBlau";
            this.MnuBlau.Size = new System.Drawing.Size(98, 22);
            this.MnuBlau.Text = "Blau";
            this.MnuBlau.Click += new System.EventHandler(this.MnuBlau_Click);
            // 
            // MnuRot
            // 
            this.MnuRot.Name = "MnuRot";
            this.MnuRot.Size = new System.Drawing.Size(98, 22);
            this.MnuRot.Text = "Rot";
            this.MnuRot.Click += new System.EventHandler(this.MnuRot_Click);
            // 
            // MnuSeparator1
            // 
            this.MnuSeparator1.Name = "MnuSeparator1";
            this.MnuSeparator1.Size = new System.Drawing.Size(178, 6);
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
            // MnuCourierNew
            // 
            this.MnuCourierNew.Checked = true;
            this.MnuCourierNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuCourierNew.Name = "MnuCourierNew";
            this.MnuCourierNew.Size = new System.Drawing.Size(140, 22);
            this.MnuCourierNew.Text = "Courier New";
            this.MnuCourierNew.Click += new System.EventHandler(this.MnuCourierNew_Click);
            // 
            // MnuSymbol
            // 
            this.MnuSymbol.Name = "MnuSymbol";
            this.MnuSymbol.Size = new System.Drawing.Size(140, 22);
            this.MnuSymbol.Text = "Symbol";
            this.MnuSymbol.Click += new System.EventHandler(this.MnuSymbol_Click);
            // 
            // MnuArial
            // 
            this.MnuArial.Name = "MnuArial";
            this.MnuArial.Size = new System.Drawing.Size(140, 22);
            this.MnuArial.Text = "Arial";
            this.MnuArial.Click += new System.EventHandler(this.MnuArial_Click);
            // 
            // CboSchriftgroesse
            // 
            this.CboSchriftgroesse.Name = "CboSchriftgroesse";
            this.CboSchriftgroesse.Size = new System.Drawing.Size(121, 23);
            this.CboSchriftgroesse.TextChanged += new System.EventHandler(this.CboSchriftgroesse_TextChanged);
            // 
            // MnuSeparator2
            // 
            this.MnuSeparator2.Name = "MnuSeparator2";
            this.MnuSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // MnuFett
            // 
            this.MnuFett.Name = "MnuFett";
            this.MnuFett.Size = new System.Drawing.Size(181, 22);
            this.MnuFett.Text = "Fett";
            this.MnuFett.Click += new System.EventHandler(this.MnuFett_Click);
            // 
            // MnuKursiv
            // 
            this.MnuKursiv.Name = "MnuKursiv";
            this.MnuKursiv.Size = new System.Drawing.Size(181, 22);
            this.MnuKursiv.Text = "Kursiv";
            this.MnuKursiv.Click += new System.EventHandler(this.MnuKursiv_Click);
            // 
            // MnuHaupt
            // 
            this.MnuHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBearbeiten,
            this.MnuAnsicht});
            this.MnuHaupt.Location = new System.Drawing.Point(0, 0);
            this.MnuHaupt.Name = "MnuHaupt";
            this.MnuHaupt.Size = new System.Drawing.Size(284, 24);
            this.MnuHaupt.TabIndex = 22;
            this.MnuHaupt.Text = "MenuStrip1";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.ContextMenuStrip = this.ConTxtMenue;
            this.TxtEingabe.Location = new System.Drawing.Point(12, 165);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 23;
            // 
            // ConTxtMenue
            // 
            this.ConTxtMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConTxtReadOnly,
            this.ConTxtMultiline});
            this.ConTxtMenue.Name = "conTxtE";
            this.ConTxtMenue.Size = new System.Drawing.Size(126, 48);
            // 
            // ConTxtReadOnly
            // 
            this.ConTxtReadOnly.Name = "ConTxtReadOnly";
            this.ConTxtReadOnly.Size = new System.Drawing.Size(125, 22);
            this.ConTxtReadOnly.Text = "ReadOnly";
            this.ConTxtReadOnly.Click += new System.EventHandler(this.ConTxtReadOnly_Click);
            // 
            // ConTxtMultiline
            // 
            this.ConTxtMultiline.Name = "ConTxtMultiline";
            this.ConTxtMultiline.Size = new System.Drawing.Size(125, 22);
            this.ConTxtMultiline.Text = "Multiline";
            this.ConTxtMultiline.Click += new System.EventHandler(this.ConTxtMultiline_Click);
            // 
            // SymHaupt
            // 
            this.SymHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SymFett,
            this.SymKursiv,
            this.SymLblSchriftgroesse,
            this.CboSymSchriftgroesse});
            this.SymHaupt.Location = new System.Drawing.Point(0, 24);
            this.SymHaupt.Name = "SymHaupt";
            this.SymHaupt.Size = new System.Drawing.Size(284, 25);
            this.SymHaupt.TabIndex = 26;
            this.SymHaupt.Text = "ToolStrip1";
            // 
            // SymFett
            // 
            this.SymFett.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SymFett.Image = ((System.Drawing.Image)(resources.GetObject("SymFett.Image")));
            this.SymFett.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SymFett.Name = "SymFett";
            this.SymFett.Size = new System.Drawing.Size(23, 22);
            this.SymFett.Text = "ToolStripButton1";
            this.SymFett.Click += new System.EventHandler(this.MnuFett_Click);
            // 
            // SymKursiv
            // 
            this.SymKursiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SymKursiv.Image = ((System.Drawing.Image)(resources.GetObject("SymKursiv.Image")));
            this.SymKursiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SymKursiv.Name = "SymKursiv";
            this.SymKursiv.Size = new System.Drawing.Size(23, 22);
            this.SymKursiv.Text = "ToolStripButton1";
            this.SymKursiv.Click += new System.EventHandler(this.MnuKursiv_Click);
            this.SymKursiv.TextChanged += new System.EventHandler(this.MnuKursiv_Click);
            // 
            // SymLblSchriftgroesse
            // 
            this.SymLblSchriftgroesse.Name = "SymLblSchriftgroesse";
            this.SymLblSchriftgroesse.Size = new System.Drawing.Size(75, 22);
            this.SymLblSchriftgroesse.Text = "Schriftgröße:";
            // 
            // CboSymSchriftgroesse
            // 
            this.CboSymSchriftgroesse.Name = "CboSymSchriftgroesse";
            this.CboSymSchriftgroesse.Size = new System.Drawing.Size(121, 25);
            this.CboSymSchriftgroesse.TextChanged += new System.EventHandler(this.CboSchriftgroesse_TextChanged);
            // 
            // StaLeiste
            // 
            this.StaLeiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaLabelZeit,
            this.StaProgressEnde});
            this.StaLeiste.Location = new System.Drawing.Point(0, 239);
            this.StaLeiste.Name = "StaLeiste";
            this.StaLeiste.Size = new System.Drawing.Size(284, 22);
            this.StaLeiste.TabIndex = 27;
            this.StaLeiste.Text = "statusStrip1";
            // 
            // StaLabelZeit
            // 
            this.StaLabelZeit.Name = "StaLabelZeit";
            this.StaLabelZeit.Size = new System.Drawing.Size(27, 17);
            this.StaLabelZeit.Text = "Zeit";
            // 
            // StaProgressEnde
            // 
            this.StaProgressEnde.Maximum = 5;
            this.StaProgressEnde.Name = "StaProgressEnde";
            this.StaProgressEnde.Size = new System.Drawing.Size(100, 16);
            // 
            // TimEndezeit
            // 
            this.TimEndezeit.Tick += new System.EventHandler(this.TimEndezeit_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StaLeiste);
            this.Controls.Add(this.SymHaupt);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.MnuHaupt);
            this.Name = "Form1";
            this.Text = "Statusleiste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConLblMenue.ResumeLayout(false);
            this.MnuHaupt.ResumeLayout(false);
            this.MnuHaupt.PerformLayout();
            this.ConTxtMenue.ResumeLayout(false);
            this.SymHaupt.ResumeLayout(false);
            this.SymHaupt.PerformLayout();
            this.StaLeiste.ResumeLayout(false);
            this.StaLeiste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.ContextMenuStrip ConLblMenue;
        internal System.Windows.Forms.ToolStripMenuItem ConLblFett;
        internal System.Windows.Forms.ToolStripMenuItem MnuBearbeiten;
        internal System.Windows.Forms.ToolStripMenuItem MnuKopieren;
        internal System.Windows.Forms.ToolStripMenuItem MnuEnde;
        internal System.Windows.Forms.ToolStripMenuItem MnuAnsicht;
        internal System.Windows.Forms.ToolStripMenuItem MnuHintergrund;
        internal System.Windows.Forms.ToolStripMenuItem MnuGelb;
        internal System.Windows.Forms.ToolStripMenuItem MnuBlau;
        internal System.Windows.Forms.ToolStripMenuItem MnuRot;
        internal System.Windows.Forms.ToolStripSeparator MnuSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem MnuSchriftart;
        internal System.Windows.Forms.ToolStripMenuItem MnuCourierNew;
        internal System.Windows.Forms.ToolStripMenuItem MnuSymbol;
        internal System.Windows.Forms.ToolStripMenuItem MnuArial;
        internal System.Windows.Forms.ToolStripComboBox CboSchriftgroesse;
        internal System.Windows.Forms.ToolStripSeparator MnuSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem MnuFett;
        internal System.Windows.Forms.ToolStripMenuItem MnuKursiv;
        internal System.Windows.Forms.MenuStrip MnuHaupt;
        internal System.Windows.Forms.TextBox TxtEingabe;
        internal System.Windows.Forms.ContextMenuStrip ConTxtMenue;
        internal System.Windows.Forms.ToolStripMenuItem ConTxtReadOnly;
        internal System.Windows.Forms.ToolStripMenuItem ConTxtMultiline;
        internal System.Windows.Forms.ToolStrip SymHaupt;
        internal System.Windows.Forms.ToolStripButton SymFett;
        internal System.Windows.Forms.ToolStripButton SymKursiv;
        internal System.Windows.Forms.ToolStripLabel SymLblSchriftgroesse;
        internal System.Windows.Forms.ToolStripComboBox CboSymSchriftgroesse;
        private System.Windows.Forms.StatusStrip StaLeiste;
        private System.Windows.Forms.ToolStripStatusLabel StaLabelZeit;
        private System.Windows.Forms.ToolStripProgressBar StaProgressEnde;
        private System.Windows.Forms.Timer TimEndezeit;
    }
}

