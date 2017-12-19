namespace BedienungTastatur
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChkMietwagen = new System.Windows.Forms.CheckBox();
            this.OptPrag = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.CmdBestellen = new System.Windows.Forms.Button();
            this.TxtEingabe4 = new System.Windows.Forms.TextBox();
            this.TxtEingabe3 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChkMietwagen
            // 
            this.ChkMietwagen.AutoSize = true;
            this.ChkMietwagen.Location = new System.Drawing.Point(232, 115);
            this.ChkMietwagen.Name = "ChkMietwagen";
            this.ChkMietwagen.Size = new System.Drawing.Size(78, 17);
            this.ChkMietwagen.TabIndex = 26;
            this.ChkMietwagen.Text = "Miet&wagen";
            this.ChkMietwagen.UseVisualStyleBackColor = true;
            // 
            // OptPrag
            // 
            this.OptPrag.AutoSize = true;
            this.OptPrag.Location = new System.Drawing.Point(232, 87);
            this.OptPrag.Name = "OptPrag";
            this.OptPrag.Size = new System.Drawing.Size(47, 17);
            this.OptPrag.TabIndex = 25;
            this.OptPrag.TabStop = true;
            this.OptPrag.Text = "P&rag";
            this.OptPrag.UseVisualStyleBackColor = true;
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(232, 64);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(48, 17);
            this.OptParis.TabIndex = 24;
            this.OptParis.TabStop = true;
            this.OptParis.Text = "&Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Checked = true;
            this.OptBerlin.Location = new System.Drawing.Point(232, 41);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(51, 17);
            this.OptBerlin.TabIndex = 23;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berl&in";
            this.OptBerlin.UseVisualStyleBackColor = true;
            // 
            // CmdBestellen
            // 
            this.CmdBestellen.Location = new System.Drawing.Point(247, 12);
            this.CmdBestellen.Name = "CmdBestellen";
            this.CmdBestellen.Size = new System.Drawing.Size(75, 23);
            this.CmdBestellen.TabIndex = 22;
            this.CmdBestellen.Text = "&Bestellen";
            this.CmdBestellen.UseVisualStyleBackColor = true;
            // 
            // TxtEingabe4
            // 
            this.TxtEingabe4.Location = new System.Drawing.Point(12, 90);
            this.TxtEingabe4.Name = "TxtEingabe4";
            this.TxtEingabe4.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe4.TabIndex = 20;
            // 
            // TxtEingabe3
            // 
            this.TxtEingabe3.Location = new System.Drawing.Point(12, 64);
            this.TxtEingabe3.Name = "TxtEingabe3";
            this.TxtEingabe3.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe3.TabIndex = 19;
            this.TxtEingabe3.TabStop = false;
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(12, 38);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe2.TabIndex = 21;
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(12, 12);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.ChkMietwagen);
            this.Controls.Add(this.OptPrag);
            this.Controls.Add(this.OptParis);
            this.Controls.Add(this.OptBerlin);
            this.Controls.Add(this.CmdBestellen);
            this.Controls.Add(this.TxtEingabe4);
            this.Controls.Add(this.TxtEingabe3);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Name = "Form1";
            this.Text = "Bedienung per Tastatur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox ChkMietwagen;
        internal System.Windows.Forms.RadioButton OptPrag;
        internal System.Windows.Forms.RadioButton OptParis;
        internal System.Windows.Forms.RadioButton OptBerlin;
        internal System.Windows.Forms.Button CmdBestellen;
        internal System.Windows.Forms.TextBox TxtEingabe4;
        internal System.Windows.Forms.TextBox TxtEingabe3;
        internal System.Windows.Forms.TextBox TxtEingabe2;
        internal System.Windows.Forms.TextBox TxtEingabe1;
    }
}

