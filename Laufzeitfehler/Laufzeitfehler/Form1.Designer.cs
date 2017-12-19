namespace Laufzeitfehler
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
            this.TxtZahl1 = new System.Windows.Forms.TextBox();
            this.TxtZahl2 = new System.Windows.Forms.TextBox();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtZahl1
            // 
            this.TxtZahl1.Location = new System.Drawing.Point(13, 13);
            this.TxtZahl1.Name = "TxtZahl1";
            this.TxtZahl1.Size = new System.Drawing.Size(100, 20);
            this.TxtZahl1.TabIndex = 0;
            // 
            // TxtZahl2
            // 
            this.TxtZahl2.Location = new System.Drawing.Point(13, 40);
            this.TxtZahl2.Name = "TxtZahl2";
            this.TxtZahl2.Size = new System.Drawing.Size(100, 20);
            this.TxtZahl2.TabIndex = 1;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 67);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(197, 13);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen.TabIndex = 3;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdRechnen);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtZahl2);
            this.Controls.Add(this.TxtZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtZahl1;
        private System.Windows.Forms.TextBox TxtZahl2;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdRechnen;
        private System.Windows.Forms.Button CmdEnde;
    }
}

