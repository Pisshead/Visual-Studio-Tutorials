namespace UListenfeld
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
            this.LstLinks = new System.Windows.Forms.ListBox();
            this.LstRechts = new System.Windows.Forms.ListBox();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdLinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstLinks
            // 
            this.LstLinks.FormattingEnabled = true;
            this.LstLinks.Location = new System.Drawing.Point(12, 12);
            this.LstLinks.Name = "LstLinks";
            this.LstLinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstLinks.Size = new System.Drawing.Size(120, 95);
            this.LstLinks.TabIndex = 0;
            // 
            // LstRechts
            // 
            this.LstRechts.FormattingEnabled = true;
            this.LstRechts.Location = new System.Drawing.Point(252, 12);
            this.LstRechts.Name = "LstRechts";
            this.LstRechts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstRechts.Size = new System.Drawing.Size(120, 95);
            this.LstRechts.TabIndex = 1;
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(154, 12);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(75, 23);
            this.CmdRechts.TabIndex = 2;
            this.CmdRechts.Text = ">>";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(154, 41);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(75, 23);
            this.CmdLinks.TabIndex = 3;
            this.CmdLinks.Text = "<<";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.CmdLinks);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.LstRechts);
            this.Controls.Add(this.LstLinks);
            this.Name = "Form1";
            this.Text = "Listenfelder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstLinks;
        private System.Windows.Forms.ListBox LstRechts;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdLinks;
    }
}

