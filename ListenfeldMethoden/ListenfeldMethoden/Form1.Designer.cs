namespace ListenfeldMethoden
{
    partial class FrmListenMethoden
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
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.LblNeu = new System.Windows.Forms.Label();
            this.TxtNeu = new System.Windows.Forms.TextBox();
            this.CmdNeu = new System.Windows.Forms.Button();
            this.LblOrt = new System.Windows.Forms.Label();
            this.OptEnde = new System.Windows.Forms.RadioButton();
            this.OptAnfang = new System.Windows.Forms.RadioButton();
            this.OptStelle = new System.Windows.Forms.RadioButton();
            this.CmdClearAll = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblAusgewaehlt = new System.Windows.Forms.Label();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdReplace = new System.Windows.Forms.Button();
            this.TxtReplace = new System.Windows.Forms.TextBox();
            this.CmdUndo = new System.Windows.Forms.Button();
            this.LblAuswahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Items.AddRange(new object[] {
            "Spaghetti",
            "Grüne Nudeln",
            "Tortellini",
            "Pizza",
            "Lasagne"});
            this.LstSpeisen.Location = new System.Drawing.Point(13, 13);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.LstSpeisen.TabIndex = 0;
            this.LstSpeisen.SelectedIndexChanged += new System.EventHandler(this.Auswahl_SelectedIndexChanged);
            // 
            // LblNeu
            // 
            this.LblNeu.AutoSize = true;
            this.LblNeu.Location = new System.Drawing.Point(178, 168);
            this.LblNeu.Name = "LblNeu";
            this.LblNeu.Size = new System.Drawing.Size(82, 13);
            this.LblNeu.TabIndex = 1;
            this.LblNeu.Text = "Neues Element:";
            // 
            // TxtNeu
            // 
            this.TxtNeu.Location = new System.Drawing.Point(181, 195);
            this.TxtNeu.Name = "TxtNeu";
            this.TxtNeu.Size = new System.Drawing.Size(153, 20);
            this.TxtNeu.TabIndex = 2;
            // 
            // CmdNeu
            // 
            this.CmdNeu.Location = new System.Drawing.Point(181, 222);
            this.CmdNeu.Name = "CmdNeu";
            this.CmdNeu.Size = new System.Drawing.Size(153, 23);
            this.CmdNeu.TabIndex = 3;
            this.CmdNeu.Text = "Einfügen";
            this.CmdNeu.UseVisualStyleBackColor = true;
            this.CmdNeu.Click += new System.EventHandler(this.CmdNeu_Click);
            // 
            // LblOrt
            // 
            this.LblOrt.AutoSize = true;
            this.LblOrt.Location = new System.Drawing.Point(181, 266);
            this.LblOrt.Name = "LblOrt";
            this.LblOrt.Size = new System.Drawing.Size(55, 13);
            this.LblOrt.TabIndex = 4;
            this.LblOrt.Text = "Einfügeort";
            // 
            // OptEnde
            // 
            this.OptEnde.AutoSize = true;
            this.OptEnde.Location = new System.Drawing.Point(181, 292);
            this.OptEnde.Name = "OptEnde";
            this.OptEnde.Size = new System.Drawing.Size(111, 17);
            this.OptEnde.TabIndex = 5;
            this.OptEnde.TabStop = true;
            this.OptEnde.Text = "Am Ende der Liste";
            this.OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            this.OptAnfang.AutoSize = true;
            this.OptAnfang.Location = new System.Drawing.Point(181, 317);
            this.OptAnfang.Name = "OptAnfang";
            this.OptAnfang.Size = new System.Drawing.Size(120, 17);
            this.OptAnfang.TabIndex = 6;
            this.OptAnfang.TabStop = true;
            this.OptAnfang.Text = "Am Anfang der Liste";
            this.OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptStelle
            // 
            this.OptStelle.AutoSize = true;
            this.OptStelle.Location = new System.Drawing.Point(181, 340);
            this.OptStelle.Name = "OptStelle";
            this.OptStelle.Size = new System.Drawing.Size(153, 17);
            this.OptStelle.TabIndex = 7;
            this.OptStelle.TabStop = true;
            this.OptStelle.Text = "Vor ausgewähltem Element";
            this.OptStelle.UseVisualStyleBackColor = true;
            // 
            // CmdClearAll
            // 
            this.CmdClearAll.Location = new System.Drawing.Point(181, 370);
            this.CmdClearAll.Name = "CmdClearAll";
            this.CmdClearAll.Size = new System.Drawing.Size(153, 23);
            this.CmdClearAll.TabIndex = 8;
            this.CmdClearAll.Text = "Alles löschen";
            this.CmdClearAll.UseVisualStyleBackColor = true;
            this.CmdClearAll.Click += new System.EventHandler(this.CmdClearAll_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(181, 445);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(153, 23);
            this.CmdEnde.TabIndex = 9;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblAusgewaehlt
            // 
            this.LblAusgewaehlt.AutoSize = true;
            this.LblAusgewaehlt.Location = new System.Drawing.Point(12, 293);
            this.LblAusgewaehlt.Name = "LblAusgewaehlt";
            this.LblAusgewaehlt.Size = new System.Drawing.Size(122, 13);
            this.LblAusgewaehlt.TabIndex = 10;
            this.LblAusgewaehlt.Text = "Ausgewwähltes Element";
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(12, 309);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 11;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdReplace
            // 
            this.CmdReplace.Location = new System.Drawing.Point(12, 338);
            this.CmdReplace.Name = "CmdReplace";
            this.CmdReplace.Size = new System.Drawing.Size(75, 23);
            this.CmdReplace.TabIndex = 12;
            this.CmdReplace.Text = "Ersetzen durch:";
            this.CmdReplace.UseVisualStyleBackColor = true;
            this.CmdReplace.Click += new System.EventHandler(this.CmdReplace_Click);
            // 
            // TxtReplace
            // 
            this.TxtReplace.Location = new System.Drawing.Point(12, 367);
            this.TxtReplace.Name = "TxtReplace";
            this.TxtReplace.Size = new System.Drawing.Size(100, 20);
            this.TxtReplace.TabIndex = 13;
            // 
            // CmdUndo
            // 
            this.CmdUndo.Location = new System.Drawing.Point(13, 445);
            this.CmdUndo.Name = "CmdUndo";
            this.CmdUndo.Size = new System.Drawing.Size(99, 23);
            this.CmdUndo.TabIndex = 14;
            this.CmdUndo.Text = "Wiederherstellen";
            this.CmdUndo.UseVisualStyleBackColor = true;
            this.CmdUndo.Click += new System.EventHandler(this.CmdUndo_Click);
            // 
            // LblAuswahl
            // 
            this.LblAuswahl.AutoSize = true;
            this.LblAuswahl.Location = new System.Drawing.Point(15, 115);
            this.LblAuswahl.Name = "LblAuswahl";
            this.LblAuswahl.Size = new System.Drawing.Size(0, 13);
            this.LblAuswahl.TabIndex = 15;
            // 
            // FrmListenMethoden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 480);
            this.Controls.Add(this.LblAuswahl);
            this.Controls.Add(this.CmdUndo);
            this.Controls.Add(this.TxtReplace);
            this.Controls.Add(this.CmdReplace);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.LblAusgewaehlt);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdClearAll);
            this.Controls.Add(this.OptStelle);
            this.Controls.Add(this.OptAnfang);
            this.Controls.Add(this.OptEnde);
            this.Controls.Add(this.LblOrt);
            this.Controls.Add(this.CmdNeu);
            this.Controls.Add(this.TxtNeu);
            this.Controls.Add(this.LblNeu);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "FrmListenMethoden";
            this.Text = "Listen Methoden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Label LblNeu;
        private System.Windows.Forms.TextBox TxtNeu;
        private System.Windows.Forms.Button CmdNeu;
        private System.Windows.Forms.Label LblOrt;
        private System.Windows.Forms.RadioButton OptEnde;
        private System.Windows.Forms.RadioButton OptAnfang;
        private System.Windows.Forms.RadioButton OptStelle;
        private System.Windows.Forms.Button CmdClearAll;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblAusgewaehlt;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Button CmdReplace;
        private System.Windows.Forms.TextBox TxtReplace;
        private System.Windows.Forms.Button CmdUndo;
        private System.Windows.Forms.Label LblAuswahl;
    }
}

