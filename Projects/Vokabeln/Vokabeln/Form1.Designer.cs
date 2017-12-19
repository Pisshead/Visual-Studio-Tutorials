namespace Vokabeln
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
            this.MnuEndeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdStart = new System.Windows.Forms.Button();
            this.MnuDE = new System.Windows.Forms.ToolStripMenuItem();
            this.LblRichtung = new System.Windows.Forms.Label();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.MnuAllgemein = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEndeProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtAntwort = new System.Windows.Forms.TextBox();
            this.MnuHaupt = new System.Windows.Forms.MenuStrip();
            this.MnuRichtung = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuED = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDF = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFD = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAnleitung = new System.Windows.Forms.ToolStripMenuItem();
            this.LblFrage = new System.Windows.Forms.Label();
            this.MnuHaupt.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuEndeTest
            // 
            this.MnuEndeTest.Name = "MnuEndeTest";
            this.MnuEndeTest.Size = new System.Drawing.Size(180, 22);
            this.MnuEndeTest.Text = "Test beenden";
            this.MnuEndeTest.Click += new System.EventHandler(this.MnuEndeTest_Click);
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(12, 202);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(100, 23);
            this.CmdStart.TabIndex = 27;
            this.CmdStart.Text = "Test starten";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // MnuDE
            // 
            this.MnuDE.Name = "MnuDE";
            this.MnuDE.Size = new System.Drawing.Size(186, 22);
            this.MnuDE.Text = "deutsch - englisch";
            this.MnuDE.Click += new System.EventHandler(this.MnuDE_Click);
            // 
            // LblRichtung
            // 
            this.LblRichtung.AutoSize = true;
            this.LblRichtung.Location = new System.Drawing.Point(14, 172);
            this.LblRichtung.Name = "LblRichtung";
            this.LblRichtung.Size = new System.Drawing.Size(89, 13);
            this.LblRichtung.TabIndex = 29;
            this.LblRichtung.Text = "englisch/deutsch";
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Enabled = false;
            this.CmdPruefen.Location = new System.Drawing.Point(12, 232);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(100, 23);
            this.CmdPruefen.TabIndex = 26;
            this.CmdPruefen.Text = "Prüfen / Nächster";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // MnuAllgemein
            // 
            this.MnuAllgemein.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEndeTest,
            this.MnuEndeProgramm});
            this.MnuAllgemein.Name = "MnuAllgemein";
            this.MnuAllgemein.Size = new System.Drawing.Size(73, 20);
            this.MnuAllgemein.Text = "Allgemein";
            // 
            // MnuEndeProgramm
            // 
            this.MnuEndeProgramm.Name = "MnuEndeProgramm";
            this.MnuEndeProgramm.Size = new System.Drawing.Size(180, 22);
            this.MnuEndeProgramm.Text = "Programm beenden";
            this.MnuEndeProgramm.Click += new System.EventHandler(this.MnuEndeProgramm_Click);
            // 
            // TxtAntwort
            // 
            this.TxtAntwort.Enabled = false;
            this.TxtAntwort.Location = new System.Drawing.Point(156, 234);
            this.TxtAntwort.Name = "TxtAntwort";
            this.TxtAntwort.Size = new System.Drawing.Size(100, 20);
            this.TxtAntwort.TabIndex = 25;
            // 
            // MnuHaupt
            // 
            this.MnuHaupt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAllgemein,
            this.MnuRichtung,
            this.MnuHilfe});
            this.MnuHaupt.Location = new System.Drawing.Point(0, 0);
            this.MnuHaupt.Name = "MnuHaupt";
            this.MnuHaupt.Size = new System.Drawing.Size(284, 24);
            this.MnuHaupt.TabIndex = 28;
            this.MnuHaupt.Text = "MenuStrip1";
            // 
            // MnuRichtung
            // 
            this.MnuRichtung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDE,
            this.MnuED,
            this.MnuDF,
            this.MnuFD});
            this.MnuRichtung.Name = "MnuRichtung";
            this.MnuRichtung.Size = new System.Drawing.Size(67, 20);
            this.MnuRichtung.Text = "Richtung";
            // 
            // MnuED
            // 
            this.MnuED.Checked = true;
            this.MnuED.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuED.Name = "MnuED";
            this.MnuED.Size = new System.Drawing.Size(186, 22);
            this.MnuED.Text = "englisch - deutsch";
            this.MnuED.Click += new System.EventHandler(this.MnuED_Click);
            // 
            // MnuDF
            // 
            this.MnuDF.Name = "MnuDF";
            this.MnuDF.Size = new System.Drawing.Size(186, 22);
            this.MnuDF.Text = "deutsch - französisch";
            this.MnuDF.Click += new System.EventHandler(this.MnuDF_Click);
            // 
            // MnuFD
            // 
            this.MnuFD.Name = "MnuFD";
            this.MnuFD.Size = new System.Drawing.Size(186, 22);
            this.MnuFD.Text = "französisch - deutsch";
            this.MnuFD.Click += new System.EventHandler(this.MnuFD_Click);
            // 
            // MnuHilfe
            // 
            this.MnuHilfe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAnleitung});
            this.MnuHilfe.Name = "MnuHilfe";
            this.MnuHilfe.Size = new System.Drawing.Size(44, 20);
            this.MnuHilfe.Text = "Hilfe";
            // 
            // MnuAnleitung
            // 
            this.MnuAnleitung.Name = "MnuAnleitung";
            this.MnuAnleitung.Size = new System.Drawing.Size(152, 22);
            this.MnuAnleitung.Text = "Anleitung";
            this.MnuAnleitung.Click += new System.EventHandler(this.MnuAnleitung_Click);
            // 
            // LblFrage
            // 
            this.LblFrage.AutoSize = true;
            this.LblFrage.Location = new System.Drawing.Point(159, 207);
            this.LblFrage.Name = "LblFrage";
            this.LblFrage.Size = new System.Drawing.Size(0, 13);
            this.LblFrage.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.LblRichtung);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.TxtAntwort);
            this.Controls.Add(this.MnuHaupt);
            this.Controls.Add(this.LblFrage);
            this.Name = "Form1";
            this.Text = "Vokabeln";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnuHaupt.ResumeLayout(false);
            this.MnuHaupt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem MnuEndeTest;
        internal System.Windows.Forms.Button CmdStart;
        internal System.Windows.Forms.ToolStripMenuItem MnuDE;
        internal System.Windows.Forms.Label LblRichtung;
        internal System.Windows.Forms.Button CmdPruefen;
        internal System.Windows.Forms.ToolStripMenuItem MnuAllgemein;
        internal System.Windows.Forms.ToolStripMenuItem MnuEndeProgramm;
        internal System.Windows.Forms.TextBox TxtAntwort;
        internal System.Windows.Forms.MenuStrip MnuHaupt;
        internal System.Windows.Forms.ToolStripMenuItem MnuRichtung;
        internal System.Windows.Forms.ToolStripMenuItem MnuED;
        internal System.Windows.Forms.ToolStripMenuItem MnuDF;
        internal System.Windows.Forms.ToolStripMenuItem MnuFD;
        internal System.Windows.Forms.ToolStripMenuItem MnuHilfe;
        internal System.Windows.Forms.ToolStripMenuItem MnuAnleitung;
        internal System.Windows.Forms.Label LblFrage;
    }
}

