namespace Datentypen
{
    partial class FrmDatentypen
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
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(101, 21);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 0;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 326);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 1;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(47, 72);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // FrmDatentypen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdAnzeige);
            this.Name = "FrmDatentypen";
            this.Text = "Datentypen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

