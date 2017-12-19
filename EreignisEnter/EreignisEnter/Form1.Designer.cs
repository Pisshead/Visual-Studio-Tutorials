namespace EreignisEnter
{
    partial class FrmEreignisEnter
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.ChkBeretisKunde = new System.Windows.Forms.CheckBox();
            this.GrpZahlungsart = new System.Windows.Forms.GroupBox();
            this.OptUeberweisung = new System.Windows.Forms.RadioButton();
            this.OptLastschrift = new System.Windows.Forms.RadioButton();
            this.OptKreditkarte = new System.Windows.Forms.RadioButton();
            this.LstLieferart = new System.Windows.Forms.ListBox();
            this.LblLieferart = new System.Windows.Forms.Label();
            this.LblHilfe = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.GrpZahlungsart.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(13, 13);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 0;
            this.TxtEingabe.Click += new System.EventHandler(this.TxtEingabe_Click);
            this.TxtEingabe.Enter += new System.EventHandler(this.TxtEingabe_Enter);
            // 
            // ChkBeretisKunde
            // 
            this.ChkBeretisKunde.AutoSize = true;
            this.ChkBeretisKunde.Location = new System.Drawing.Point(13, 40);
            this.ChkBeretisKunde.Name = "ChkBeretisKunde";
            this.ChkBeretisKunde.Size = new System.Drawing.Size(98, 17);
            this.ChkBeretisKunde.TabIndex = 1;
            this.ChkBeretisKunde.Text = "Bereits Kunde?";
            this.ChkBeretisKunde.UseVisualStyleBackColor = true;
            this.ChkBeretisKunde.Enter += new System.EventHandler(this.ChkBeretisKunde_Enter);
            // 
            // GrpZahlungsart
            // 
            this.GrpZahlungsart.Controls.Add(this.OptUeberweisung);
            this.GrpZahlungsart.Controls.Add(this.OptLastschrift);
            this.GrpZahlungsart.Controls.Add(this.OptKreditkarte);
            this.GrpZahlungsart.Location = new System.Drawing.Point(13, 64);
            this.GrpZahlungsart.Name = "GrpZahlungsart";
            this.GrpZahlungsart.Size = new System.Drawing.Size(121, 100);
            this.GrpZahlungsart.TabIndex = 2;
            this.GrpZahlungsart.TabStop = false;
            this.GrpZahlungsart.Text = "Zahlungsart";
            // 
            // OptUeberweisung
            // 
            this.OptUeberweisung.AutoSize = true;
            this.OptUeberweisung.Location = new System.Drawing.Point(0, 68);
            this.OptUeberweisung.Name = "OptUeberweisung";
            this.OptUeberweisung.Size = new System.Drawing.Size(87, 17);
            this.OptUeberweisung.TabIndex = 2;
            this.OptUeberweisung.TabStop = true;
            this.OptUeberweisung.Text = "Überweisung";
            this.OptUeberweisung.UseVisualStyleBackColor = true;
            // 
            // OptLastschrift
            // 
            this.OptLastschrift.AutoSize = true;
            this.OptLastschrift.Location = new System.Drawing.Point(0, 44);
            this.OptLastschrift.Name = "OptLastschrift";
            this.OptLastschrift.Size = new System.Drawing.Size(73, 17);
            this.OptLastschrift.TabIndex = 1;
            this.OptLastschrift.TabStop = true;
            this.OptLastschrift.Text = "Lastschrift";
            this.OptLastschrift.UseVisualStyleBackColor = true;
            // 
            // OptKreditkarte
            // 
            this.OptKreditkarte.AutoSize = true;
            this.OptKreditkarte.Location = new System.Drawing.Point(0, 20);
            this.OptKreditkarte.Name = "OptKreditkarte";
            this.OptKreditkarte.Size = new System.Drawing.Size(76, 17);
            this.OptKreditkarte.TabIndex = 0;
            this.OptKreditkarte.TabStop = true;
            this.OptKreditkarte.Text = "Kreditkarte";
            this.OptKreditkarte.UseVisualStyleBackColor = true;
            this.OptKreditkarte.CheckedChanged += new System.EventHandler(this.OptZahlungsform_CheckedChanged);
            // 
            // LstLieferart
            // 
            this.LstLieferart.FormattingEnabled = true;
            this.LstLieferart.Location = new System.Drawing.Point(12, 189);
            this.LstLieferart.Name = "LstLieferart";
            this.LstLieferart.Size = new System.Drawing.Size(120, 95);
            this.LstLieferart.TabIndex = 3;
            this.LstLieferart.Enter += new System.EventHandler(this.LstLieferart_Enter);
            // 
            // LblLieferart
            // 
            this.LblLieferart.AutoSize = true;
            this.LblLieferart.Location = new System.Drawing.Point(13, 170);
            this.LblLieferart.Name = "LblLieferart";
            this.LblLieferart.Size = new System.Drawing.Size(45, 13);
            this.LblLieferart.TabIndex = 4;
            this.LblLieferart.Text = "Lieferart";
            // 
            // LblHilfe
            // 
            this.LblHilfe.AutoSize = true;
            this.LblHilfe.Location = new System.Drawing.Point(12, 310);
            this.LblHilfe.Name = "LblHilfe";
            this.LblHilfe.Size = new System.Drawing.Size(0, 13);
            this.LblHilfe.TabIndex = 5;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 330);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmEreignisEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 365);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblHilfe);
            this.Controls.Add(this.LblLieferart);
            this.Controls.Add(this.LstLieferart);
            this.Controls.Add(this.GrpZahlungsart);
            this.Controls.Add(this.ChkBeretisKunde);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "FrmEreignisEnter";
            this.Text = "Ereignis Enter";
            this.Activated += new System.EventHandler(this.FrmEreignisEnter_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpZahlungsart.ResumeLayout(false);
            this.GrpZahlungsart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.CheckBox ChkBeretisKunde;
        private System.Windows.Forms.GroupBox GrpZahlungsart;
        private System.Windows.Forms.RadioButton OptUeberweisung;
        private System.Windows.Forms.RadioButton OptLastschrift;
        private System.Windows.Forms.RadioButton OptKreditkarte;
        private System.Windows.Forms.ListBox LstLieferart;
        private System.Windows.Forms.Label LblLieferart;
        private System.Windows.Forms.Label LblHilfe;
        private System.Windows.Forms.Button CmdEnde;
    }
}

