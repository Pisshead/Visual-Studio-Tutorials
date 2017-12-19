namespace Kontrollkaestchen
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
            this.CmdUmschalten = new System.Windows.Forms.Button();
            this.ChkSchalter = new System.Windows.Forms.CheckBox();
            this.LblSchalter = new System.Windows.Forms.Label();
            this.LblPruefung = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(154, 34);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(118, 23);
            this.CmdPruefen.TabIndex = 0;
            this.CmdPruefen.Text = "Prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdUmschalten
            // 
            this.CmdUmschalten.Location = new System.Drawing.Point(154, 168);
            this.CmdUmschalten.Name = "CmdUmschalten";
            this.CmdUmschalten.Size = new System.Drawing.Size(118, 23);
            this.CmdUmschalten.TabIndex = 1;
            this.CmdUmschalten.Text = "Schalter umschalten";
            this.CmdUmschalten.UseVisualStyleBackColor = true;
            this.CmdUmschalten.Click += new System.EventHandler(this.CmdUmschalten_Click);
            // 
            // ChkSchalter
            // 
            this.ChkSchalter.AutoSize = true;
            this.ChkSchalter.Checked = true;
            this.ChkSchalter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSchalter.Location = new System.Drawing.Point(154, 123);
            this.ChkSchalter.Name = "ChkSchalter";
            this.ChkSchalter.Size = new System.Drawing.Size(65, 17);
            this.ChkSchalter.TabIndex = 2;
            this.ChkSchalter.Text = "Schalter";
            this.ChkSchalter.UseVisualStyleBackColor = true;
            this.ChkSchalter.CheckedChanged += new System.EventHandler(this.ChkSchalter_CheckedChanged);
            // 
            // LblSchalter
            // 
            this.LblSchalter.AutoSize = true;
            this.LblSchalter.Location = new System.Drawing.Point(56, 124);
            this.LblSchalter.Name = "LblSchalter";
            this.LblSchalter.Size = new System.Drawing.Size(0, 13);
            this.LblSchalter.TabIndex = 3;
            // 
            // LblPruefung
            // 
            this.LblPruefung.AutoSize = true;
            this.LblPruefung.Location = new System.Drawing.Point(59, 39);
            this.LblPruefung.Name = "LblPruefung";
            this.LblPruefung.Size = new System.Drawing.Size(0, 13);
            this.LblPruefung.TabIndex = 4;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(196, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 5;
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
            this.Controls.Add(this.LblPruefung);
            this.Controls.Add(this.LblSchalter);
            this.Controls.Add(this.ChkSchalter);
            this.Controls.Add(this.CmdUmschalten);
            this.Controls.Add(this.CmdPruefen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdUmschalten;
        private System.Windows.Forms.CheckBox ChkSchalter;
        private System.Windows.Forms.Label LblSchalter;
        private System.Windows.Forms.Label LblPruefung;
        private System.Windows.Forms.Button CmdEnde;
    }
}

