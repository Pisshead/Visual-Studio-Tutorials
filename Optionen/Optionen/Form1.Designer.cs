namespace Optionen
{
    partial class Form1
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
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.CmdRotSchalten = new System.Windows.Forms.Button();
            this.OptRot = new System.Windows.Forms.RadioButton();
            this.OptGruen = new System.Windows.Forms.RadioButton();
            this.OptBlau = new System.Windows.Forms.RadioButton();
            this.LblPruefung = new System.Windows.Forms.Label();
            this.LblTest = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(185, 12);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(75, 23);
            this.CmdPruefen.TabIndex = 0;
            this.CmdPruefen.Text = "Prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdRotSchalten
            // 
            this.CmdRotSchalten.Location = new System.Drawing.Point(185, 175);
            this.CmdRotSchalten.Name = "CmdRotSchalten";
            this.CmdRotSchalten.Size = new System.Drawing.Size(75, 45);
            this.CmdRotSchalten.TabIndex = 1;
            this.CmdRotSchalten.Text = "Auf Rot schalten";
            this.CmdRotSchalten.UseVisualStyleBackColor = true;
            this.CmdRotSchalten.Click += new System.EventHandler(this.CmdRotSchalten_Click);
            // 
            // OptRot
            // 
            this.OptRot.AutoSize = true;
            this.OptRot.Location = new System.Drawing.Point(185, 53);
            this.OptRot.Name = "OptRot";
            this.OptRot.Size = new System.Drawing.Size(42, 17);
            this.OptRot.TabIndex = 2;
            this.OptRot.TabStop = true;
            this.OptRot.Text = "Rot";
            this.OptRot.UseVisualStyleBackColor = true;
            this.OptRot.CheckedChanged += new System.EventHandler(this.OptRot_CheckedChanged);
            // 
            // OptGruen
            // 
            this.OptGruen.AutoSize = true;
            this.OptGruen.Location = new System.Drawing.Point(185, 91);
            this.OptGruen.Name = "OptGruen";
            this.OptGruen.Size = new System.Drawing.Size(48, 17);
            this.OptGruen.TabIndex = 3;
            this.OptGruen.TabStop = true;
            this.OptGruen.Text = "Grün";
            this.OptGruen.UseVisualStyleBackColor = true;
            this.OptGruen.CheckedChanged += new System.EventHandler(this.OptGruen_CheckedChanged);
            // 
            // OptBlau
            // 
            this.OptBlau.AutoSize = true;
            this.OptBlau.Location = new System.Drawing.Point(185, 132);
            this.OptBlau.Name = "OptBlau";
            this.OptBlau.Size = new System.Drawing.Size(46, 17);
            this.OptBlau.TabIndex = 4;
            this.OptBlau.TabStop = true;
            this.OptBlau.Text = "Blau";
            this.OptBlau.UseVisualStyleBackColor = true;
            this.OptBlau.CheckedChanged += new System.EventHandler(this.OptBlau_CheckedChanged);
            // 
            // LblPruefung
            // 
            this.LblPruefung.AutoSize = true;
            this.LblPruefung.Location = new System.Drawing.Point(13, 22);
            this.LblPruefung.Name = "LblPruefung";
            this.LblPruefung.Size = new System.Drawing.Size(0, 13);
            this.LblPruefung.TabIndex = 5;
            // 
            // LblTest
            // 
            this.LblTest.AutoSize = true;
            this.LblTest.Location = new System.Drawing.Point(16, 226);
            this.LblTest.Name = "LblTest";
            this.LblTest.Size = new System.Drawing.Size(0, 13);
            this.LblTest.TabIndex = 6;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(185, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 7;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblTest);
            this.Controls.Add(this.LblPruefung);
            this.Controls.Add(this.OptBlau);
            this.Controls.Add(this.OptGruen);
            this.Controls.Add(this.OptRot);
            this.Controls.Add(this.CmdRotSchalten);
            this.Controls.Add(this.CmdPruefen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdRotSchalten;
        private System.Windows.Forms.RadioButton OptRot;
        private System.Windows.Forms.RadioButton OptGruen;
        private System.Windows.Forms.RadioButton OptBlau;
        private System.Windows.Forms.Label LblPruefung;
        private System.Windows.Forms.Label LblTest;
        private System.Windows.Forms.Button CmdEnde;
    }
}

