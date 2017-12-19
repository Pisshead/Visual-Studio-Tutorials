namespace BedienungTastatur
{
    partial class FrmBedienungTastatur
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
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.TxtEingabe3 = new System.Windows.Forms.TextBox();
            this.TxtEingabe4 = new System.Windows.Forms.TextBox();
            this.CmdBestellen = new System.Windows.Forms.Button();
            this.GrpStadt = new System.Windows.Forms.GroupBox();
            this.ChkMietwagen = new System.Windows.Forms.CheckBox();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptPrag = new System.Windows.Forms.RadioButton();
            this.GrpStadt.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(13, 13);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe1.TabIndex = 0;
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(13, 40);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe2.TabIndex = 3;
            // 
            // TxtEingabe3
            // 
            this.TxtEingabe3.Location = new System.Drawing.Point(13, 67);
            this.TxtEingabe3.Name = "TxtEingabe3";
            this.TxtEingabe3.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe3.TabIndex = 1;
            this.TxtEingabe3.TabStop = false;
            // 
            // TxtEingabe4
            // 
            this.TxtEingabe4.Location = new System.Drawing.Point(13, 94);
            this.TxtEingabe4.Name = "TxtEingabe4";
            this.TxtEingabe4.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe4.TabIndex = 2;
            // 
            // CmdBestellen
            // 
            this.CmdBestellen.Location = new System.Drawing.Point(197, 13);
            this.CmdBestellen.Name = "CmdBestellen";
            this.CmdBestellen.Size = new System.Drawing.Size(75, 23);
            this.CmdBestellen.TabIndex = 4;
            this.CmdBestellen.Text = "&Bestellen";
            this.CmdBestellen.UseVisualStyleBackColor = true;
            // 
            // GrpStadt
            // 
            this.GrpStadt.Controls.Add(this.OptPrag);
            this.GrpStadt.Controls.Add(this.OptParis);
            this.GrpStadt.Controls.Add(this.OptBerlin);
            this.GrpStadt.Location = new System.Drawing.Point(155, 42);
            this.GrpStadt.Name = "GrpStadt";
            this.GrpStadt.Size = new System.Drawing.Size(117, 100);
            this.GrpStadt.TabIndex = 5;
            this.GrpStadt.TabStop = false;
            this.GrpStadt.Text = "Stadt";
            // 
            // ChkMietwagen
            // 
            this.ChkMietwagen.AutoSize = true;
            this.ChkMietwagen.Location = new System.Drawing.Point(155, 149);
            this.ChkMietwagen.Name = "ChkMietwagen";
            this.ChkMietwagen.Size = new System.Drawing.Size(78, 17);
            this.ChkMietwagen.TabIndex = 6;
            this.ChkMietwagen.Text = "Miet&wagen";
            this.ChkMietwagen.UseVisualStyleBackColor = true;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 7;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Checked = true;
            this.OptBerlin.Location = new System.Drawing.Point(7, 20);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(51, 17);
            this.OptBerlin.TabIndex = 0;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berl&in";
            this.OptBerlin.UseVisualStyleBackColor = true;
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(7, 44);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(48, 17);
            this.OptParis.TabIndex = 1;
            this.OptParis.Text = "&Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            // 
            // OptPrag
            // 
            this.OptPrag.AutoSize = true;
            this.OptPrag.Location = new System.Drawing.Point(7, 68);
            this.OptPrag.Name = "OptPrag";
            this.OptPrag.Size = new System.Drawing.Size(47, 17);
            this.OptPrag.TabIndex = 2;
            this.OptPrag.Text = "P&rag";
            this.OptPrag.UseVisualStyleBackColor = true;
            // 
            // FrmBedienungTastatur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.ChkMietwagen);
            this.Controls.Add(this.GrpStadt);
            this.Controls.Add(this.CmdBestellen);
            this.Controls.Add(this.TxtEingabe4);
            this.Controls.Add(this.TxtEingabe3);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Name = "FrmBedienungTastatur";
            this.Text = "Bedienung Tastatur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpStadt.ResumeLayout(false);
            this.GrpStadt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe1;
        private System.Windows.Forms.TextBox TxtEingabe2;
        private System.Windows.Forms.TextBox TxtEingabe3;
        private System.Windows.Forms.TextBox TxtEingabe4;
        private System.Windows.Forms.Button CmdBestellen;
        private System.Windows.Forms.GroupBox GrpStadt;
        private System.Windows.Forms.CheckBox ChkMietwagen;
        private System.Windows.Forms.RadioButton OptPrag;
        private System.Windows.Forms.RadioButton OptParis;
        private System.Windows.Forms.RadioButton OptBerlin;
        private System.Windows.Forms.Button CmdEnde;
    }
}

