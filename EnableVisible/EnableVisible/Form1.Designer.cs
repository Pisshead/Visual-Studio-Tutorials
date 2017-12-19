namespace EnableVisible
{
    partial class FrmEnableVisible
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
            this.CmdRechnen1 = new System.Windows.Forms.Button();
            this.CmdRechnen2 = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.TxtZahl1 = new System.Windows.Forms.TextBox();
            this.TxtZahl2 = new System.Windows.Forms.TextBox();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdRechnen1
            // 
            this.CmdRechnen1.Enabled = false;
            this.CmdRechnen1.Location = new System.Drawing.Point(13, 226);
            this.CmdRechnen1.Name = "CmdRechnen1";
            this.CmdRechnen1.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen1.TabIndex = 0;
            this.CmdRechnen1.Text = "Rechnen1";
            this.CmdRechnen1.UseVisualStyleBackColor = true;
            this.CmdRechnen1.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // CmdRechnen2
            // 
            this.CmdRechnen2.Location = new System.Drawing.Point(95, 225);
            this.CmdRechnen2.Name = "CmdRechnen2";
            this.CmdRechnen2.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen2.TabIndex = 1;
            this.CmdRechnen2.Text = "Rechnen2";
            this.CmdRechnen2.UseVisualStyleBackColor = true;
            this.CmdRechnen2.Visible = false;
            this.CmdRechnen2.Click += new System.EventHandler(this.CmdRechnen_Click);
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
            // TxtZahl1
            // 
            this.TxtZahl1.Location = new System.Drawing.Point(13, 13);
            this.TxtZahl1.Name = "TxtZahl1";
            this.TxtZahl1.Size = new System.Drawing.Size(100, 20);
            this.TxtZahl1.TabIndex = 3;
            this.TxtZahl1.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // TxtZahl2
            // 
            this.TxtZahl2.Location = new System.Drawing.Point(137, 12);
            this.TxtZahl2.Name = "TxtZahl2";
            this.TxtZahl2.Size = new System.Drawing.Size(100, 20);
            this.TxtZahl2.TabIndex = 4;
            this.TxtZahl2.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(13, 109);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 13);
            this.LblAusgabe.TabIndex = 5;
            // 
            // FrmEnableVisible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.TxtZahl2);
            this.Controls.Add(this.TxtZahl1);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdRechnen2);
            this.Controls.Add(this.CmdRechnen1);
            this.Name = "FrmEnableVisible";
            this.Text = "Enable Visible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdRechnen1;
        private System.Windows.Forms.Button CmdRechnen2;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.TextBox TxtZahl1;
        private System.Windows.Forms.TextBox TxtZahl2;
        private System.Windows.Forms.Label LblAusgabe;
    }
}

