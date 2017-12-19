namespace TastaturMaus
{
    partial class FrmTastaturMaus
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
            this.TxtTastatur = new System.Windows.Forms.TextBox();
            this.pMouse = new System.Windows.Forms.Panel();
            this.LblTastatur = new System.Windows.Forms.Label();
            this.LblMouse = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTastatur
            // 
            this.TxtTastatur.Location = new System.Drawing.Point(13, 13);
            this.TxtTastatur.Name = "TxtTastatur";
            this.TxtTastatur.Size = new System.Drawing.Size(100, 20);
            this.TxtTastatur.TabIndex = 0;
            this.TxtTastatur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTastatur_KeyDown);
            // 
            // pMouse
            // 
            this.pMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMouse.Location = new System.Drawing.Point(13, 142);
            this.pMouse.Name = "pMouse";
            this.pMouse.Size = new System.Drawing.Size(200, 100);
            this.pMouse.TabIndex = 1;
            this.pMouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMouse_MouseDown);
            // 
            // LblTastatur
            // 
            this.LblTastatur.AutoSize = true;
            this.LblTastatur.Location = new System.Drawing.Point(13, 40);
            this.LblTastatur.Name = "LblTastatur";
            this.LblTastatur.Size = new System.Drawing.Size(0, 13);
            this.LblTastatur.TabIndex = 2;
            // 
            // LblMouse
            // 
            this.LblMouse.AutoSize = true;
            this.LblMouse.Location = new System.Drawing.Point(16, 245);
            this.LblMouse.Name = "LblMouse";
            this.LblMouse.Size = new System.Drawing.Size(0, 13);
            this.LblMouse.TabIndex = 3;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(274, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmTastaturMaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblMouse);
            this.Controls.Add(this.LblTastatur);
            this.Controls.Add(this.pMouse);
            this.Controls.Add(this.TxtTastatur);
            this.Name = "FrmTastaturMaus";
            this.Text = "Tastatur und Maus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTastatur;
        private System.Windows.Forms.Panel pMouse;
        private System.Windows.Forms.Label LblTastatur;
        private System.Windows.Forms.Label LblMouse;
        private System.Windows.Forms.Button CmdEnde;
    }
}

