namespace MethodenRueckgabe
{
    partial class FrmMethodenRueckgabe
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
            this.CmdMaxwert = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdMaxwert
            // 
            this.CmdMaxwert.Location = new System.Drawing.Point(197, 13);
            this.CmdMaxwert.Name = "CmdMaxwert";
            this.CmdMaxwert.Size = new System.Drawing.Size(75, 23);
            this.CmdMaxwert.TabIndex = 0;
            this.CmdMaxwert.Text = "Maximum";
            this.CmdMaxwert.UseVisualStyleBackColor = true;
            this.CmdMaxwert.Click += new System.EventHandler(this.CmdMaxwert_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 1;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmMethodenRueckgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdMaxwert);
            this.Name = "FrmMethodenRueckgabe";
            this.Text = "Rückgabe von Methoden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMaxwert;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnde;
    }
}

