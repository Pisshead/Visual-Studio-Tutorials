namespace DatumPicker
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
            this.LblPlusTag = new System.Windows.Forms.Label();
            this.LblUhrzeit = new System.Windows.Forms.Label();
            this.DatPicker4 = new System.Windows.Forms.DateTimePicker();
            this.LblUpDown = new System.Windows.Forms.Label();
            this.LblEigenes = new System.Windows.Forms.Label();
            this.LblStandard = new System.Windows.Forms.Label();
            this.DatPicker3 = new System.Windows.Forms.DateTimePicker();
            this.DatPicker2 = new System.Windows.Forms.DateTimePicker();
            this.LblDatum = new System.Windows.Forms.Label();
            this.DatPicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LblPlusTag
            // 
            this.LblPlusTag.AutoSize = true;
            this.LblPlusTag.Location = new System.Drawing.Point(220, 136);
            this.LblPlusTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPlusTag.Name = "LblPlusTag";
            this.LblPlusTag.Size = new System.Drawing.Size(30, 13);
            this.LblPlusTag.TabIndex = 40;
            this.LblPlusTag.Text = "(leer)";
            // 
            // LblUhrzeit
            // 
            this.LblUhrzeit.AutoSize = true;
            this.LblUhrzeit.Location = new System.Drawing.Point(11, 76);
            this.LblUhrzeit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUhrzeit.Name = "LblUhrzeit";
            this.LblUhrzeit.Size = new System.Drawing.Size(43, 13);
            this.LblUhrzeit.TabIndex = 39;
            this.LblUhrzeit.Text = "Uhrzeit:";
            // 
            // DatPicker4
            // 
            this.DatPicker4.Location = new System.Drawing.Point(123, 76);
            this.DatPicker4.Margin = new System.Windows.Forms.Padding(2);
            this.DatPicker4.Name = "DatPicker4";
            this.DatPicker4.Size = new System.Drawing.Size(100, 20);
            this.DatPicker4.TabIndex = 38;
            this.DatPicker4.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // LblUpDown
            // 
            this.LblUpDown.AutoSize = true;
            this.LblUpDown.Location = new System.Drawing.Point(11, 55);
            this.LblUpDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUpDown.Name = "LblUpDown";
            this.LblUpDown.Size = new System.Drawing.Size(52, 13);
            this.LblUpDown.TabIndex = 37;
            this.LblUpDown.Text = "UpDown:";
            // 
            // LblEigenes
            // 
            this.LblEigenes.AutoSize = true;
            this.LblEigenes.Location = new System.Drawing.Point(11, 32);
            this.LblEigenes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEigenes.Name = "LblEigenes";
            this.LblEigenes.Size = new System.Drawing.Size(83, 13);
            this.LblEigenes.TabIndex = 36;
            this.LblEigenes.Text = "Eigenes Format:";
            // 
            // LblStandard
            // 
            this.LblStandard.AutoSize = true;
            this.LblStandard.Location = new System.Drawing.Point(11, 9);
            this.LblStandard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStandard.Name = "LblStandard";
            this.LblStandard.Size = new System.Drawing.Size(53, 13);
            this.LblStandard.TabIndex = 35;
            this.LblStandard.Text = "Standard:";
            // 
            // DatPicker3
            // 
            this.DatPicker3.Location = new System.Drawing.Point(123, 55);
            this.DatPicker3.Margin = new System.Windows.Forms.Padding(2);
            this.DatPicker3.Name = "DatPicker3";
            this.DatPicker3.Size = new System.Drawing.Size(100, 20);
            this.DatPicker3.TabIndex = 34;
            this.DatPicker3.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // DatPicker2
            // 
            this.DatPicker2.Location = new System.Drawing.Point(123, 32);
            this.DatPicker2.Margin = new System.Windows.Forms.Padding(2);
            this.DatPicker2.Name = "DatPicker2";
            this.DatPicker2.Size = new System.Drawing.Size(100, 20);
            this.DatPicker2.TabIndex = 33;
            this.DatPicker2.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // LblDatum
            // 
            this.LblDatum.AutoSize = true;
            this.LblDatum.Location = new System.Drawing.Point(220, 112);
            this.LblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDatum.Name = "LblDatum";
            this.LblDatum.Size = new System.Drawing.Size(30, 13);
            this.LblDatum.TabIndex = 32;
            this.LblDatum.Text = "(leer)";
            // 
            // DatPicker1
            // 
            this.DatPicker1.Location = new System.Drawing.Point(123, 9);
            this.DatPicker1.Margin = new System.Windows.Forms.Padding(2);
            this.DatPicker1.Name = "DatPicker1";
            this.DatPicker1.Size = new System.Drawing.Size(200, 20);
            this.DatPicker1.TabIndex = 31;
            this.DatPicker1.ValueChanged += new System.EventHandler(this.DatPicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.LblPlusTag);
            this.Controls.Add(this.LblUhrzeit);
            this.Controls.Add(this.DatPicker4);
            this.Controls.Add(this.LblUpDown);
            this.Controls.Add(this.LblEigenes);
            this.Controls.Add(this.LblStandard);
            this.Controls.Add(this.DatPicker3);
            this.Controls.Add(this.DatPicker2);
            this.Controls.Add(this.LblDatum);
            this.Controls.Add(this.DatPicker1);
            this.Name = "Form1";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblPlusTag;
        internal System.Windows.Forms.Label LblUhrzeit;
        internal System.Windows.Forms.DateTimePicker DatPicker4;
        internal System.Windows.Forms.Label LblUpDown;
        internal System.Windows.Forms.Label LblEigenes;
        internal System.Windows.Forms.Label LblStandard;
        internal System.Windows.Forms.DateTimePicker DatPicker3;
        internal System.Windows.Forms.DateTimePicker DatPicker2;
        internal System.Windows.Forms.Label LblDatum;
        internal System.Windows.Forms.DateTimePicker DatPicker1;
    }
}

