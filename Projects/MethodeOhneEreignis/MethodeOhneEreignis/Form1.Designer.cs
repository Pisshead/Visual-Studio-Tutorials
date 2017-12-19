namespace MethodeOhneEreignis
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
            this.GrpUrlaubsort = new System.Windows.Forms.GroupBox();
            this.OptRom = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.GrpUnterkunft = new System.Windows.Forms.GroupBox();
            this.OptHotel = new System.Windows.Forms.RadioButton();
            this.OptPension = new System.Windows.Forms.RadioButton();
            this.OptAppartement = new System.Windows.Forms.RadioButton();
            this.GrpUrlaubsort.SuspendLayout();
            this.GrpUnterkunft.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpUrlaubsort
            // 
            this.GrpUrlaubsort.Controls.Add(this.OptRom);
            this.GrpUrlaubsort.Controls.Add(this.OptParis);
            this.GrpUrlaubsort.Controls.Add(this.OptBerlin);
            this.GrpUrlaubsort.Location = new System.Drawing.Point(9, 36);
            this.GrpUrlaubsort.Name = "GrpUrlaubsort";
            this.GrpUrlaubsort.Size = new System.Drawing.Size(150, 100);
            this.GrpUrlaubsort.TabIndex = 4;
            this.GrpUrlaubsort.TabStop = false;
            this.GrpUrlaubsort.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            this.OptRom.AutoSize = true;
            this.OptRom.Location = new System.Drawing.Point(6, 65);
            this.OptRom.Name = "OptRom";
            this.OptRom.Size = new System.Drawing.Size(47, 17);
            this.OptRom.TabIndex = 2;
            this.OptRom.Text = "Rom";
            this.OptRom.UseVisualStyleBackColor = true;
            this.OptRom.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(6, 42);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(48, 17);
            this.OptParis.TabIndex = 1;
            this.OptParis.Text = "Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            this.OptParis.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Checked = true;
            this.OptBerlin.Location = new System.Drawing.Point(6, 19);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(51, 17);
            this.OptBerlin.TabIndex = 0;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berlin";
            this.OptBerlin.UseVisualStyleBackColor = true;
            this.OptBerlin.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 9);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "(leer)";
            // 
            // GrpUnterkunft
            // 
            this.GrpUnterkunft.Controls.Add(this.OptHotel);
            this.GrpUnterkunft.Controls.Add(this.OptPension);
            this.GrpUnterkunft.Controls.Add(this.OptAppartement);
            this.GrpUnterkunft.Location = new System.Drawing.Point(215, 36);
            this.GrpUnterkunft.Name = "GrpUnterkunft";
            this.GrpUnterkunft.Size = new System.Drawing.Size(150, 100);
            this.GrpUnterkunft.TabIndex = 3;
            this.GrpUnterkunft.TabStop = false;
            this.GrpUnterkunft.Text = "Unterkunft";
            // 
            // OptHotel
            // 
            this.OptHotel.AutoSize = true;
            this.OptHotel.Location = new System.Drawing.Point(6, 65);
            this.OptHotel.Name = "OptHotel";
            this.OptHotel.Size = new System.Drawing.Size(50, 17);
            this.OptHotel.TabIndex = 5;
            this.OptHotel.Text = "Hotel";
            this.OptHotel.UseVisualStyleBackColor = true;
            this.OptHotel.CheckedChanged += new System.EventHandler(this.OptUnterkunft_CheckedChanged);
            // 
            // OptPension
            // 
            this.OptPension.AutoSize = true;
            this.OptPension.Checked = true;
            this.OptPension.Location = new System.Drawing.Point(6, 42);
            this.OptPension.Name = "OptPension";
            this.OptPension.Size = new System.Drawing.Size(63, 17);
            this.OptPension.TabIndex = 4;
            this.OptPension.TabStop = true;
            this.OptPension.Text = "Pension";
            this.OptPension.UseVisualStyleBackColor = true;
            this.OptPension.CheckedChanged += new System.EventHandler(this.OptUnterkunft_CheckedChanged);
            // 
            // OptAppartement
            // 
            this.OptAppartement.AutoSize = true;
            this.OptAppartement.Location = new System.Drawing.Point(6, 19);
            this.OptAppartement.Name = "OptAppartement";
            this.OptAppartement.Size = new System.Drawing.Size(85, 17);
            this.OptAppartement.TabIndex = 3;
            this.OptAppartement.Text = "Appartement";
            this.OptAppartement.UseVisualStyleBackColor = true;
            this.OptAppartement.CheckedChanged += new System.EventHandler(this.OptUnterkunft_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.GrpUrlaubsort);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.GrpUnterkunft);
            this.Name = "Form1";
            this.Text = "Methode ohne Ereignis";
            this.GrpUrlaubsort.ResumeLayout(false);
            this.GrpUrlaubsort.PerformLayout();
            this.GrpUnterkunft.ResumeLayout(false);
            this.GrpUnterkunft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpUrlaubsort;
        private System.Windows.Forms.RadioButton OptRom;
        private System.Windows.Forms.RadioButton OptParis;
        private System.Windows.Forms.RadioButton OptBerlin;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.GroupBox GrpUnterkunft;
        private System.Windows.Forms.RadioButton OptHotel;
        private System.Windows.Forms.RadioButton OptPension;
        private System.Windows.Forms.RadioButton OptAppartement;
    }
}

