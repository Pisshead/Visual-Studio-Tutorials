namespace Schieberegler
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
            this.TrkRot = new System.Windows.Forms.TrackBar();
            this.TrkGruen = new System.Windows.Forms.TrackBar();
            this.TrkBlau = new System.Windows.Forms.TrackBar();
            this.LblRot = new System.Windows.Forms.Label();
            this.LblRotWert = new System.Windows.Forms.Label();
            this.LblGruen = new System.Windows.Forms.Label();
            this.LblGruenWert = new System.Windows.Forms.Label();
            this.LblBlau = new System.Windows.Forms.Label();
            this.LblBlauWert = new System.Windows.Forms.Label();
            this.PanFarbe = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TrkRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkGruen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkBlau)).BeginInit();
            this.SuspendLayout();
            // 
            // TrkRot
            // 
            this.TrkRot.LargeChange = 32;
            this.TrkRot.Location = new System.Drawing.Point(12, 12);
            this.TrkRot.Maximum = 255;
            this.TrkRot.Name = "TrkRot";
            this.TrkRot.Size = new System.Drawing.Size(200, 45);
            this.TrkRot.SmallChange = 8;
            this.TrkRot.TabIndex = 0;
            this.TrkRot.TickFrequency = 16;
            this.TrkRot.Value = 128;
            this.TrkRot.ValueChanged += new System.EventHandler(this.Schieberegler_ValueChanged);
            // 
            // TrkGruen
            // 
            this.TrkGruen.LargeChange = 32;
            this.TrkGruen.Location = new System.Drawing.Point(12, 63);
            this.TrkGruen.Maximum = 255;
            this.TrkGruen.Name = "TrkGruen";
            this.TrkGruen.Size = new System.Drawing.Size(200, 45);
            this.TrkGruen.SmallChange = 8;
            this.TrkGruen.TabIndex = 1;
            this.TrkGruen.TickFrequency = 16;
            this.TrkGruen.Value = 128;
            this.TrkGruen.ValueChanged += new System.EventHandler(this.Schieberegler_ValueChanged);
            // 
            // TrkBlau
            // 
            this.TrkBlau.LargeChange = 32;
            this.TrkBlau.Location = new System.Drawing.Point(12, 114);
            this.TrkBlau.Maximum = 255;
            this.TrkBlau.Name = "TrkBlau";
            this.TrkBlau.Size = new System.Drawing.Size(200, 45);
            this.TrkBlau.SmallChange = 8;
            this.TrkBlau.TabIndex = 2;
            this.TrkBlau.TickFrequency = 16;
            this.TrkBlau.Value = 128;
            this.TrkBlau.ValueChanged += new System.EventHandler(this.Schieberegler_ValueChanged);
            // 
            // LblRot
            // 
            this.LblRot.AutoSize = true;
            this.LblRot.Location = new System.Drawing.Point(218, 12);
            this.LblRot.Name = "LblRot";
            this.LblRot.Size = new System.Drawing.Size(24, 13);
            this.LblRot.TabIndex = 3;
            this.LblRot.Text = "Rot";
            // 
            // LblRotWert
            // 
            this.LblRotWert.AutoSize = true;
            this.LblRotWert.Location = new System.Drawing.Point(218, 30);
            this.LblRotWert.Name = "LblRotWert";
            this.LblRotWert.Size = new System.Drawing.Size(25, 13);
            this.LblRotWert.TabIndex = 4;
            this.LblRotWert.Text = "128";
            // 
            // LblGruen
            // 
            this.LblGruen.AutoSize = true;
            this.LblGruen.Location = new System.Drawing.Point(218, 63);
            this.LblGruen.Name = "LblGruen";
            this.LblGruen.Size = new System.Drawing.Size(30, 13);
            this.LblGruen.TabIndex = 5;
            this.LblGruen.Text = "Grün";
            // 
            // LblGruenWert
            // 
            this.LblGruenWert.AutoSize = true;
            this.LblGruenWert.Location = new System.Drawing.Point(218, 80);
            this.LblGruenWert.Name = "LblGruenWert";
            this.LblGruenWert.Size = new System.Drawing.Size(25, 13);
            this.LblGruenWert.TabIndex = 6;
            this.LblGruenWert.Text = "128";
            // 
            // LblBlau
            // 
            this.LblBlau.AutoSize = true;
            this.LblBlau.Location = new System.Drawing.Point(218, 114);
            this.LblBlau.Name = "LblBlau";
            this.LblBlau.Size = new System.Drawing.Size(28, 13);
            this.LblBlau.TabIndex = 7;
            this.LblBlau.Text = "Blau";
            // 
            // LblBlauWert
            // 
            this.LblBlauWert.AutoSize = true;
            this.LblBlauWert.Location = new System.Drawing.Point(218, 131);
            this.LblBlauWert.Name = "LblBlauWert";
            this.LblBlauWert.Size = new System.Drawing.Size(25, 13);
            this.LblBlauWert.TabIndex = 8;
            this.LblBlauWert.Text = "128";
            // 
            // PanFarbe
            // 
            this.PanFarbe.BackColor = System.Drawing.Color.Gray;
            this.PanFarbe.Location = new System.Drawing.Point(259, 8);
            this.PanFarbe.Name = "PanFarbe";
            this.PanFarbe.Size = new System.Drawing.Size(140, 140);
            this.PanFarbe.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.PanFarbe);
            this.Controls.Add(this.LblBlauWert);
            this.Controls.Add(this.LblBlau);
            this.Controls.Add(this.LblGruenWert);
            this.Controls.Add(this.LblGruen);
            this.Controls.Add(this.LblRotWert);
            this.Controls.Add(this.LblRot);
            this.Controls.Add(this.TrkBlau);
            this.Controls.Add(this.TrkGruen);
            this.Controls.Add(this.TrkRot);
            this.Name = "Form1";
            this.Text = "Schieberegler";
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
        private System.Windows.Forms.Label LblRotWert;
        private System.Windows.Forms.Label LblGruen;
        private System.Windows.Forms.Label LblGruenWert;
        private System.Windows.Forms.Label LblBlau;
        private System.Windows.Forms.Label LblBlauWert;
        private System.Windows.Forms.Panel PanFarbe;
    }
}

