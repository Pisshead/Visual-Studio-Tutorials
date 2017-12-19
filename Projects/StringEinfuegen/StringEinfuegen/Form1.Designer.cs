namespace StringEinfuegen
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
            this.LblEinfuegen2 = new System.Windows.Forms.Label();
            this.NumEinfuegen = new System.Windows.Forms.NumericUpDown();
            this.LblEinfuegen1 = new System.Windows.Forms.Label();
            this.TxtEinfuegen = new System.Windows.Forms.TextBox();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumEinfuegen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEinfuegen2
            // 
            this.LblEinfuegen2.AutoSize = true;
            this.LblEinfuegen2.Location = new System.Drawing.Point(12, 164);
            this.LblEinfuegen2.Name = "LblEinfuegen2";
            this.LblEinfuegen2.Size = new System.Drawing.Size(64, 13);
            this.LblEinfuegen2.TabIndex = 59;
            this.LblEinfuegen2.Text = "bei Position:";
            // 
            // NumEinfuegen
            // 
            this.NumEinfuegen.Location = new System.Drawing.Point(12, 180);
            this.NumEinfuegen.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumEinfuegen.Name = "NumEinfuegen";
            this.NumEinfuegen.Size = new System.Drawing.Size(100, 20);
            this.NumEinfuegen.TabIndex = 58;
            // 
            // LblEinfuegen1
            // 
            this.LblEinfuegen1.AutoSize = true;
            this.LblEinfuegen1.Location = new System.Drawing.Point(12, 125);
            this.LblEinfuegen1.Name = "LblEinfuegen1";
            this.LblEinfuegen1.Size = new System.Drawing.Size(51, 13);
            this.LblEinfuegen1.TabIndex = 57;
            this.LblEinfuegen1.Text = "Füge ein:";
            // 
            // TxtEinfuegen
            // 
            this.TxtEinfuegen.Location = new System.Drawing.Point(12, 141);
            this.TxtEinfuegen.Name = "TxtEinfuegen";
            this.TxtEinfuegen.Size = new System.Drawing.Size(100, 20);
            this.TxtEinfuegen.TabIndex = 56;
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(12, 18);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 55;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 70);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 54;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(12, 206);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(75, 23);
            this.CmdEinfuegen.TabIndex = 53;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 34);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(150, 20);
            this.TxtEingabe.TabIndex = 52;
            this.TxtEingabe.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblEinfuegen2);
            this.Controls.Add(this.NumEinfuegen);
            this.Controls.Add(this.LblEinfuegen1);
            this.Controls.Add(this.TxtEinfuegen);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEinfuegen);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Einfügen";
            ((System.ComponentModel.ISupportInitialize)(this.NumEinfuegen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblEinfuegen2;
        internal System.Windows.Forms.NumericUpDown NumEinfuegen;
        internal System.Windows.Forms.Label LblEinfuegen1;
        internal System.Windows.Forms.TextBox TxtEinfuegen;
        internal System.Windows.Forms.Label LblEingabe;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdEinfuegen;
        internal System.Windows.Forms.TextBox TxtEingabe;
    }
}

