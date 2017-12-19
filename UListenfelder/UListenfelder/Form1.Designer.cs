namespace UListenfelder
{
    partial class FrmUListenfelder
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
            this.LstLaenderLinks = new System.Windows.Forms.ListBox();
            this.CmdToTheRight = new System.Windows.Forms.Button();
            this.CmdToTheLeft = new System.Windows.Forms.Button();
            this.LstLaenderRechts = new System.Windows.Forms.ListBox();
            this.LblLinks = new System.Windows.Forms.Label();
            this.CmdReset = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblRechts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstLaenderLinks
            // 
            this.LstLaenderLinks.FormattingEnabled = true;
            this.LstLaenderLinks.Location = new System.Drawing.Point(13, 13);
            this.LstLaenderLinks.Name = "LstLaenderLinks";
            this.LstLaenderLinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstLaenderLinks.Size = new System.Drawing.Size(120, 95);
            this.LstLaenderLinks.TabIndex = 0;
            this.LstLaenderLinks.SelectedIndexChanged += new System.EventHandler(this.Links_SelectedIndexChanged);
            // 
            // CmdToTheRight
            // 
            this.CmdToTheRight.Location = new System.Drawing.Point(192, 35);
            this.CmdToTheRight.Name = "CmdToTheRight";
            this.CmdToTheRight.Size = new System.Drawing.Size(75, 23);
            this.CmdToTheRight.TabIndex = 1;
            this.CmdToTheRight.Text = ">>";
            this.CmdToTheRight.UseVisualStyleBackColor = true;
            this.CmdToTheRight.Click += new System.EventHandler(this.CmdToTheRight_Click);
            // 
            // CmdToTheLeft
            // 
            this.CmdToTheLeft.Location = new System.Drawing.Point(192, 65);
            this.CmdToTheLeft.Name = "CmdToTheLeft";
            this.CmdToTheLeft.Size = new System.Drawing.Size(75, 23);
            this.CmdToTheLeft.TabIndex = 2;
            this.CmdToTheLeft.Text = "<<";
            this.CmdToTheLeft.UseVisualStyleBackColor = true;
            this.CmdToTheLeft.Click += new System.EventHandler(this.CmdToTheLeft_Click);
            // 
            // LstLaenderRechts
            // 
            this.LstLaenderRechts.FormattingEnabled = true;
            this.LstLaenderRechts.Location = new System.Drawing.Point(334, 13);
            this.LstLaenderRechts.Name = "LstLaenderRechts";
            this.LstLaenderRechts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstLaenderRechts.Size = new System.Drawing.Size(120, 95);
            this.LstLaenderRechts.TabIndex = 3;
            this.LstLaenderRechts.SelectedIndexChanged += new System.EventHandler(this.Rechts_SelectedIndexChanged);
            // 
            // LblLinks
            // 
            this.LblLinks.AutoSize = true;
            this.LblLinks.Location = new System.Drawing.Point(10, 141);
            this.LblLinks.Name = "LblLinks";
            this.LblLinks.Size = new System.Drawing.Size(0, 13);
            this.LblLinks.TabIndex = 4;
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(13, 226);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(75, 23);
            this.CmdReset.TabIndex = 5;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(373, 225);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblRechts
            // 
            this.LblRechts.AutoSize = true;
            this.LblRechts.Location = new System.Drawing.Point(334, 115);
            this.LblRechts.Name = "LblRechts";
            this.LblRechts.Size = new System.Drawing.Size(0, 13);
            this.LblRechts.TabIndex = 7;
            // 
            // FrmUListenfelder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.LblRechts);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.LblLinks);
            this.Controls.Add(this.LstLaenderRechts);
            this.Controls.Add(this.CmdToTheLeft);
            this.Controls.Add(this.CmdToTheRight);
            this.Controls.Add(this.LstLaenderLinks);
            this.Name = "FrmUListenfelder";
            this.Text = "Übung Listenfelder";
            this.Load += new System.EventHandler(this.FrmUListenfelder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstLaenderLinks;
        private System.Windows.Forms.Button CmdToTheRight;
        private System.Windows.Forms.Button CmdToTheLeft;
        private System.Windows.Forms.ListBox LstLaenderRechts;
        private System.Windows.Forms.Label LblLinks;
        private System.Windows.Forms.Button CmdReset;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblRechts;
    }
}

