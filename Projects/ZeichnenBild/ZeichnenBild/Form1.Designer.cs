﻿namespace ZeichnenBild
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
            this.CmdAuswahl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdAuswahl
            // 
            this.CmdAuswahl.Location = new System.Drawing.Point(217, 12);
            this.CmdAuswahl.Name = "CmdAuswahl";
            this.CmdAuswahl.Size = new System.Drawing.Size(75, 23);
            this.CmdAuswahl.TabIndex = 4;
            this.CmdAuswahl.Text = "Auswahl";
            this.CmdAuswahl.UseVisualStyleBackColor = true;
            this.CmdAuswahl.Click += new System.EventHandler(this.CmdAuswahl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.CmdAuswahl);
            this.Name = "Form1";
            this.Text = "Zeichnen, Bild";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdAuswahl;
    }
}

