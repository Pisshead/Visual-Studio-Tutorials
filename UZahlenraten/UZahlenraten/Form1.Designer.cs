namespace UZahlenraten
{
    partial class FrmZahlenraten
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
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblHinweis = new System.Windows.Forms.Label();
            this.TxtRaten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(197, 13);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(196, 98);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(75, 23);
            this.CmdPruefen.TabIndex = 1;
            this.CmdPruefen.Text = "Prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(13, 73);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(0, 13);
            this.LblInfo.TabIndex = 3;
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(13, 98);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 4;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // LblHinweis
            // 
            this.LblHinweis.AutoSize = true;
            this.LblHinweis.Location = new System.Drawing.Point(13, 226);
            this.LblHinweis.Name = "LblHinweis";
            this.LblHinweis.Size = new System.Drawing.Size(47, 13);
            this.LblHinweis.TabIndex = 5;
            this.LblHinweis.Text = "Hinweis:";
            // 
            // TxtRaten
            // 
            this.TxtRaten.Location = new System.Drawing.Point(69, 98);
            this.TxtRaten.Name = "TxtRaten";
            this.TxtRaten.Size = new System.Drawing.Size(100, 20);
            this.TxtRaten.TabIndex = 6;
            // 
            // FrmZahlenraten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtRaten);
            this.Controls.Add(this.LblHinweis);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.CmdStart);
            this.Name = "FrmZahlenraten";
            this.Text = "Zahlenraten (1-100)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblEingabe;
        private System.Windows.Forms.Label LblHinweis;
        private System.Windows.Forms.TextBox TxtRaten;
    }
}

