namespace Panel
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
            this.CmdNachOben = new System.Windows.Forms.Button();
            this.CmdNachLinks = new System.Windows.Forms.Button();
            this.CmdNachRechts = new System.Windows.Forms.Button();
            this.CmdNachUnten = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CmdNachOben
            // 
            this.CmdNachOben.Location = new System.Drawing.Point(142, 12);
            this.CmdNachOben.Name = "CmdNachOben";
            this.CmdNachOben.Size = new System.Drawing.Size(100, 23);
            this.CmdNachOben.TabIndex = 0;
            this.CmdNachOben.Text = "Nach Oben";
            this.CmdNachOben.UseVisualStyleBackColor = true;
            this.CmdNachOben.Click += new System.EventHandler(this.CmdNachOben_Click);
            // 
            // CmdNachLinks
            // 
            this.CmdNachLinks.Location = new System.Drawing.Point(12, 122);
            this.CmdNachLinks.Name = "CmdNachLinks";
            this.CmdNachLinks.Size = new System.Drawing.Size(100, 23);
            this.CmdNachLinks.TabIndex = 1;
            this.CmdNachLinks.Text = "Nach Links";
            this.CmdNachLinks.UseVisualStyleBackColor = true;
            this.CmdNachLinks.Click += new System.EventHandler(this.CmdNachLinks_Click);
            // 
            // CmdNachRechts
            // 
            this.CmdNachRechts.Location = new System.Drawing.Point(272, 122);
            this.CmdNachRechts.Name = "CmdNachRechts";
            this.CmdNachRechts.Size = new System.Drawing.Size(100, 23);
            this.CmdNachRechts.TabIndex = 2;
            this.CmdNachRechts.Text = "Nach Rechts";
            this.CmdNachRechts.UseVisualStyleBackColor = true;
            this.CmdNachRechts.Click += new System.EventHandler(this.CmdNachRechts_Click);
            // 
            // CmdNachUnten
            // 
            this.CmdNachUnten.Location = new System.Drawing.Point(142, 226);
            this.CmdNachUnten.Name = "CmdNachUnten";
            this.CmdNachUnten.Size = new System.Drawing.Size(100, 23);
            this.CmdNachUnten.TabIndex = 3;
            this.CmdNachUnten.Text = "Nach Unten";
            this.CmdNachUnten.UseVisualStyleBackColor = true;
            this.CmdNachUnten.Click += new System.EventHandler(this.CmdNachUnten_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.p.Location = new System.Drawing.Point(142, 82);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 100);
            this.p.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.p);
            this.Controls.Add(this.CmdNachUnten);
            this.Controls.Add(this.CmdNachRechts);
            this.Controls.Add(this.CmdNachLinks);
            this.Controls.Add(this.CmdNachOben);
            this.Name = "Form1";
            this.Text = "Panel bewegen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdNachOben;
        private System.Windows.Forms.Button CmdNachLinks;
        private System.Windows.Forms.Button CmdNachRechts;
        private System.Windows.Forms.Button CmdNachUnten;
        private System.Windows.Forms.Panel p;
    }
}

