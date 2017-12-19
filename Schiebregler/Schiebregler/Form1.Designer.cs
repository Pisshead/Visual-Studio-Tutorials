namespace Schiebregler
{
    partial class FrmSchiebregler
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
            this.TrkRot = new System.Windows.Forms.TrackBar();
            this.TrkGruen = new System.Windows.Forms.TrackBar();
            this.TrkBlau = new System.Windows.Forms.TrackBar();
            this.LblRot = new System.Windows.Forms.Label();
            this.LblGruen = new System.Windows.Forms.Label();
            this.LblBlau = new System.Windows.Forms.Label();
            this.pFarbwechsel = new System.Windows.Forms.Panel();
            this.CmdEnde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlau)).BeginInit();
            this.SuspendLayout();
            // 
            // TrkRot
            // 
            this.TrkRot.Location = new System.Drawing.Point(47, 36);
            this.TrkRot.Maximum = 255;
            this.TrkRot.Name = "TrkRot";
            this.TrkRot.Size = new System.Drawing.Size(104, 45);
            this.TrkRot.TabIndex = 0;
            this.TrkRot.ValueChanged += new System.EventHandler(this.TrkSchiebregler_ValueChanged);
            // 
            // TrkGruen
            // 
            this.TrkGruen.Location = new System.Drawing.Point(47, 87);
            this.TrkGruen.Maximum = 255;
            this.TrkGruen.Name = "TrkGruen";
            this.TrkGruen.Size = new System.Drawing.Size(104, 45);
            this.TrkGruen.TabIndex = 1;
            this.TrkGruen.ValueChanged += new System.EventHandler(this.TrkSchiebregler_ValueChanged);
            // 
            // TrkBlau
            // 
            this.TrkBlau.Location = new System.Drawing.Point(47, 139);
            this.TrkBlau.Maximum = 255;
            this.TrkBlau.Name = "TrkBlau";
            this.TrkBlau.Size = new System.Drawing.Size(104, 45);
            this.TrkBlau.TabIndex = 2;
            this.TrkBlau.ValueChanged += new System.EventHandler(this.TrkSchiebregler_ValueChanged);
            // 
            // LblRot
            // 
            this.LblRot.AutoSize = true;
            this.LblRot.Location = new System.Drawing.Point(181, 36);
            this.LblRot.Name = "LblRot";
            this.LblRot.Size = new System.Drawing.Size(24, 13);
            this.LblRot.TabIndex = 3;
            this.LblRot.Text = "Rot";
            // 
            // LblGruen
            // 
            this.LblGruen.AutoSize = true;
            this.LblGruen.Location = new System.Drawing.Point(184, 87);
            this.LblGruen.Name = "LblGruen";
            this.LblGruen.Size = new System.Drawing.Size(30, 13);
            this.LblGruen.TabIndex = 4;
            this.LblGruen.Text = "Grün";
            // 
            // LblBlau
            // 
            this.LblBlau.AutoSize = true;
            this.LblBlau.Location = new System.Drawing.Point(184, 139);
            this.LblBlau.Name = "LblBlau";
            this.LblBlau.Size = new System.Drawing.Size(28, 13);
            this.LblBlau.TabIndex = 5;
            this.LblBlau.Text = "Blau";
            // 
            // pFarbwechsel
            // 
            this.pFarbwechsel.Location = new System.Drawing.Point(281, 36);
            this.pFarbwechsel.Name = "pFarbwechsel";
            this.pFarbwechsel.Size = new System.Drawing.Size(200, 188);
            this.pFarbwechsel.TabIndex = 6;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(47, 200);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 7;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmSchiebregler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.pFarbwechsel);
            this.Controls.Add(this.LblBlau);
            this.Controls.Add(this.LblGruen);
            this.Controls.Add(this.LblRot);
            this.Controls.Add(this.TrkBlau);
            this.Controls.Add(this.TrkGruen);
            this.Controls.Add(this.TrkRot);
            this.Name = "FrmSchiebregler";
            this.Text = "Schiebregler";
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrkRot;
        private System.Windows.Forms.TrackBar TrkGruen;
        private System.Windows.Forms.TrackBar TrkBlau;
        private System.Windows.Forms.Label LblRot;
        private System.Windows.Forms.Label LblGruen;
        private System.Windows.Forms.Label LblBlau;
        private System.Windows.Forms.Panel pFarbwechsel;
        private System.Windows.Forms.Button CmdEnde;
    }
}

