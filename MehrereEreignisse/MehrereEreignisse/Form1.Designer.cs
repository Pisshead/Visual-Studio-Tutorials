namespace MehrereEreignisse
{
    partial class FrmMehrereEreignisse
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
            this.OptRot = new System.Windows.Forms.RadioButton();
            this.OptGruen = new System.Windows.Forms.RadioButton();
            this.OptBlau = new System.Windows.Forms.RadioButton();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptRot
            // 
            this.OptRot.AutoSize = true;
            this.OptRot.Location = new System.Drawing.Point(182, 81);
            this.OptRot.Name = "OptRot";
            this.OptRot.Size = new System.Drawing.Size(42, 17);
            this.OptRot.TabIndex = 0;
            this.OptRot.TabStop = true;
            this.OptRot.Text = "Rot";
            this.OptRot.UseVisualStyleBackColor = true;
            this.OptRot.CheckedChanged += new System.EventHandler(this.OptChecked_CheckedChanged);
            // 
            // OptGruen
            // 
            this.OptGruen.AutoSize = true;
            this.OptGruen.Location = new System.Drawing.Point(182, 120);
            this.OptGruen.Name = "OptGruen";
            this.OptGruen.Size = new System.Drawing.Size(48, 17);
            this.OptGruen.TabIndex = 1;
            this.OptGruen.TabStop = true;
            this.OptGruen.Text = "Grün";
            this.OptGruen.UseVisualStyleBackColor = true;
            this.OptGruen.CheckedChanged += new System.EventHandler(this.OptChecked_CheckedChanged);
            // 
            // OptBlau
            // 
            this.OptBlau.AutoSize = true;
            this.OptBlau.Location = new System.Drawing.Point(182, 157);
            this.OptBlau.Name = "OptBlau";
            this.OptBlau.Size = new System.Drawing.Size(46, 17);
            this.OptBlau.TabIndex = 2;
            this.OptBlau.TabStop = true;
            this.OptBlau.Text = "Blau";
            this.OptBlau.UseVisualStyleBackColor = true;
            this.OptBlau.CheckedChanged += new System.EventHandler(this.OptChecked_CheckedChanged);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(33, 120);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 3;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmMehrereEreignisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.OptBlau);
            this.Controls.Add(this.OptGruen);
            this.Controls.Add(this.OptRot);
            this.Name = "FrmMehrereEreignisse";
            this.Text = "Mehrere Ereignisse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OptRot;
        private System.Windows.Forms.RadioButton OptGruen;
        private System.Windows.Forms.RadioButton OptBlau;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnde;
    }
}

