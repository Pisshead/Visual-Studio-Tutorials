namespace UEnableVisible
{
    partial class FrmUEnabledVisible
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
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LstList = new System.Windows.Forms.ListBox();
            this.CmdReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(13, 226);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 0;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 1;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click_1);
            // 
            // LstList
            // 
            this.LstList.FormattingEnabled = true;
            this.LstList.Location = new System.Drawing.Point(13, 13);
            this.LstList.Name = "LstList";
            this.LstList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstList.Size = new System.Drawing.Size(120, 95);
            this.LstList.TabIndex = 2;
            this.LstList.SelectedIndexChanged += new System.EventHandler(this.Loeschen_SelectedIndexChanged);
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(95, 226);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(75, 23);
            this.CmdReset.TabIndex = 3;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // FrmUEnabledVisible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.LstList);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdLoeschen);
            this.Name = "FrmUEnabledVisible";
            this.Text = "Übung zu Enable und Visible";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.ListBox LstList;
        private System.Windows.Forms.Button CmdReset;
    }
}

