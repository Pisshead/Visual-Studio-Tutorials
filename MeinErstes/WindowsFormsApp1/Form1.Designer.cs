namespace MeinErstes
{
    partial class Form1
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdHallo = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnzeige.Location = new System.Drawing.Point(105, 57);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(75, 15);
            this.LblAnzeige.TabIndex = 0;
            // 
            // CmdHallo
            // 
            this.CmdHallo.Location = new System.Drawing.Point(105, 111);
            this.CmdHallo.Name = "CmdHallo";
            this.CmdHallo.Size = new System.Drawing.Size(75, 23);
            this.CmdHallo.TabIndex = 1;
            this.CmdHallo.Text = "Hallo";
            this.CmdHallo.UseVisualStyleBackColor = true;
            this.CmdHallo.Click += new System.EventHandler(this.CmdHallo_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(105, 181);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdHallo);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Mein erstes Programm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdHallo;
        private System.Windows.Forms.Button CmdEnde;
    }
}

