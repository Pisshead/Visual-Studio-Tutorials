namespace Objektgruppen
{
    partial class FrmOptionsgruppen
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
            this.GpBUnterkunft = new System.Windows.Forms.GroupBox();
            this.GpBUrlaubsort = new System.Windows.Forms.GroupBox();
            this.OptRom = new System.Windows.Forms.RadioButton();
            this.OptBerlin = new System.Windows.Forms.RadioButton();
            this.OptParis = new System.Windows.Forms.RadioButton();
            this.OptAppartement = new System.Windows.Forms.RadioButton();
            this.OptPension = new System.Windows.Forms.RadioButton();
            this.OptHotel = new System.Windows.Forms.RadioButton();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.GpBUnterkunft.SuspendLayout();
            this.GpBUrlaubsort.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpBUnterkunft
            // 
            this.GpBUnterkunft.Controls.Add(this.OptHotel);
            this.GpBUnterkunft.Controls.Add(this.OptPension);
            this.GpBUnterkunft.Controls.Add(this.OptAppartement);
            this.GpBUnterkunft.Location = new System.Drawing.Point(248, 78);
            this.GpBUnterkunft.Name = "GpBUnterkunft";
            this.GpBUnterkunft.Size = new System.Drawing.Size(162, 100);
            this.GpBUnterkunft.TabIndex = 0;
            this.GpBUnterkunft.TabStop = false;
            this.GpBUnterkunft.Text = "Unterkunft";
            // 
            // GpBUrlaubsort
            // 
            this.GpBUrlaubsort.Controls.Add(this.OptParis);
            this.GpBUrlaubsort.Controls.Add(this.OptBerlin);
            this.GpBUrlaubsort.Controls.Add(this.OptRom);
            this.GpBUrlaubsort.Location = new System.Drawing.Point(24, 78);
            this.GpBUrlaubsort.Name = "GpBUrlaubsort";
            this.GpBUrlaubsort.Size = new System.Drawing.Size(162, 100);
            this.GpBUrlaubsort.TabIndex = 1;
            this.GpBUrlaubsort.TabStop = false;
            this.GpBUrlaubsort.Text = "Urlaubsort";
            // 
            // OptRom
            // 
            this.OptRom.AutoSize = true;
            this.OptRom.Location = new System.Drawing.Point(7, 20);
            this.OptRom.Name = "OptRom";
            this.OptRom.Size = new System.Drawing.Size(47, 17);
            this.OptRom.TabIndex = 0;
            this.OptRom.TabStop = true;
            this.OptRom.Text = "Rom";
            this.OptRom.UseVisualStyleBackColor = true;
            this.OptRom.CheckedChanged += new System.EventHandler(this.OptUrlaubsort_CheckedChanged);
            // 
            // OptBerlin
            // 
            this.OptBerlin.AutoSize = true;
            this.OptBerlin.Location = new System.Drawing.Point(7, 44);
            this.OptBerlin.Name = "OptBerlin";
            this.OptBerlin.Size = new System.Drawing.Size(51, 17);
            this.OptBerlin.TabIndex = 1;
            this.OptBerlin.TabStop = true;
            this.OptBerlin.Text = "Berlin";
            this.OptBerlin.UseVisualStyleBackColor = true;
            // 
            // OptParis
            // 
            this.OptParis.AutoSize = true;
            this.OptParis.Location = new System.Drawing.Point(7, 68);
            this.OptParis.Name = "OptParis";
            this.OptParis.Size = new System.Drawing.Size(48, 17);
            this.OptParis.TabIndex = 2;
            this.OptParis.TabStop = true;
            this.OptParis.Text = "Paris";
            this.OptParis.UseVisualStyleBackColor = true;
            // 
            // OptAppartement
            // 
            this.OptAppartement.AutoSize = true;
            this.OptAppartement.Location = new System.Drawing.Point(7, 20);
            this.OptAppartement.Name = "OptAppartement";
            this.OptAppartement.Size = new System.Drawing.Size(85, 17);
            this.OptAppartement.TabIndex = 0;
            this.OptAppartement.TabStop = true;
            this.OptAppartement.Text = "Appartement";
            this.OptAppartement.UseVisualStyleBackColor = true;
            this.OptAppartement.CheckedChanged += new System.EventHandler(this.OptUNterkunft_CheckedChanged);
            // 
            // OptPension
            // 
            this.OptPension.AutoSize = true;
            this.OptPension.Location = new System.Drawing.Point(7, 44);
            this.OptPension.Name = "OptPension";
            this.OptPension.Size = new System.Drawing.Size(63, 17);
            this.OptPension.TabIndex = 1;
            this.OptPension.TabStop = true;
            this.OptPension.Text = "Pension";
            this.OptPension.UseVisualStyleBackColor = true;
            // 
            // OptHotel
            // 
            this.OptHotel.AutoSize = true;
            this.OptHotel.Location = new System.Drawing.Point(7, 68);
            this.OptHotel.Name = "OptHotel";
            this.OptHotel.Size = new System.Drawing.Size(50, 17);
            this.OptHotel.TabIndex = 2;
            this.OptHotel.TabStop = true;
            this.OptHotel.Text = "Hotel";
            this.OptHotel.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(28, 36);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // FrmOptionsgruppen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.GpBUrlaubsort);
            this.Controls.Add(this.GpBUnterkunft);
            this.Name = "FrmOptionsgruppen";
            this.Text = "Optionsgruppen";
            this.GpBUnterkunft.ResumeLayout(false);
            this.GpBUnterkunft.PerformLayout();
            this.GpBUrlaubsort.ResumeLayout(false);
            this.GpBUrlaubsort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpBUnterkunft;
        private System.Windows.Forms.GroupBox GpBUrlaubsort;
        private System.Windows.Forms.RadioButton OptHotel;
        private System.Windows.Forms.RadioButton OptPension;
        private System.Windows.Forms.RadioButton OptAppartement;
        private System.Windows.Forms.RadioButton OptParis;
        private System.Windows.Forms.RadioButton OptBerlin;
        private System.Windows.Forms.RadioButton OptRom;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

