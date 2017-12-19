namespace Panel
{
    partial class FrmPanelVerschieben
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
            this.CmdNachOben = new System.Windows.Forms.Button();
            this.CmdNachLinks = new System.Windows.Forms.Button();
            this.CmdNachRechts = new System.Windows.Forms.Button();
            this.CmdNachUnten = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Panel();
            this.CmdReset = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdNachOben
            // 
            this.CmdNachOben.Location = new System.Drawing.Point(181, 12);
            this.CmdNachOben.Name = "CmdNachOben";
            this.CmdNachOben.Size = new System.Drawing.Size(75, 37);
            this.CmdNachOben.TabIndex = 0;
            this.CmdNachOben.Text = "Nach Oben verschieben";
            this.CmdNachOben.UseVisualStyleBackColor = true;
            this.CmdNachOben.Click += new System.EventHandler(this.CmdNachOben_Click);
            // 
            // CmdNachLinks
            // 
            this.CmdNachLinks.Location = new System.Drawing.Point(12, 171);
            this.CmdNachLinks.Name = "CmdNachLinks";
            this.CmdNachLinks.Size = new System.Drawing.Size(75, 34);
            this.CmdNachLinks.TabIndex = 1;
            this.CmdNachLinks.Text = "Nach Links verschieben";
            this.CmdNachLinks.UseVisualStyleBackColor = true;
            this.CmdNachLinks.Click += new System.EventHandler(this.CmdNachLinks_Click);
            // 
            // CmdNachRechts
            // 
            this.CmdNachRechts.Location = new System.Drawing.Point(368, 171);
            this.CmdNachRechts.Name = "CmdNachRechts";
            this.CmdNachRechts.Size = new System.Drawing.Size(86, 34);
            this.CmdNachRechts.TabIndex = 2;
            this.CmdNachRechts.Text = "Nach Rechts verschieben";
            this.CmdNachRechts.UseVisualStyleBackColor = true;
            this.CmdNachRechts.Click += new System.EventHandler(this.CmdNachRechts_Click);
            // 
            // CmdNachUnten
            // 
            this.CmdNachUnten.Location = new System.Drawing.Point(181, 345);
            this.CmdNachUnten.Name = "CmdNachUnten";
            this.CmdNachUnten.Size = new System.Drawing.Size(75, 42);
            this.CmdNachUnten.TabIndex = 3;
            this.CmdNachUnten.Text = "Nach Unten verschieben";
            this.CmdNachUnten.UseVisualStyleBackColor = true;
            this.CmdNachUnten.Click += new System.EventHandler(this.CmdNachUnten_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.p.Location = new System.Drawing.Point(145, 80);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 100);
            this.p.TabIndex = 4;
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(368, 345);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(75, 23);
            this.CmdReset.TabIndex = 5;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(22, 355);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmPanelVerschieben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 399);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.p);
            this.Controls.Add(this.CmdNachUnten);
            this.Controls.Add(this.CmdNachRechts);
            this.Controls.Add(this.CmdNachLinks);
            this.Controls.Add(this.CmdNachOben);
            this.Name = "FrmPanelVerschieben";
            this.Text = "Panel verschieben";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdNachOben;
        private System.Windows.Forms.Button CmdNachLinks;
        private System.Windows.Forms.Button CmdNachRechts;
        private System.Windows.Forms.Button CmdNachUnten;
        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Button CmdReset;
        private System.Windows.Forms.Button CmdEnde;
    }
}

