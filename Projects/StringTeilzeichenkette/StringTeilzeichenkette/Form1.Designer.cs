namespace StringTeilzeichenkette
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
            this.NumPosition = new System.Windows.Forms.NumericUpDown();
            this.LblLaenge = new System.Windows.Forms.Label();
            this.NumLaenge = new System.Windows.Forms.NumericUpDown();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdAnzeigen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLaenge)).BeginInit();
            this.SuspendLayout();
            // 
            // NumPosition
            // 
            this.NumPosition.Location = new System.Drawing.Point(12, 142);
            this.NumPosition.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumPosition.Name = "NumPosition";
            this.NumPosition.Size = new System.Drawing.Size(100, 20);
            this.NumPosition.TabIndex = 77;
            this.NumPosition.ValueChanged += new System.EventHandler(this.NumPosition_ValueChanged);
            // 
            // LblLaenge
            // 
            this.LblLaenge.AutoSize = true;
            this.LblLaenge.Location = new System.Drawing.Point(12, 165);
            this.LblLaenge.Name = "LblLaenge";
            this.LblLaenge.Size = new System.Drawing.Size(40, 13);
            this.LblLaenge.TabIndex = 76;
            this.LblLaenge.Text = "Länge:";
            // 
            // NumLaenge
            // 
            this.NumLaenge.Location = new System.Drawing.Point(12, 181);
            this.NumLaenge.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumLaenge.Name = "NumLaenge";
            this.NumLaenge.Size = new System.Drawing.Size(100, 20);
            this.NumLaenge.TabIndex = 75;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(12, 126);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(107, 13);
            this.LblPosition.TabIndex = 74;
            this.LblPosition.Text = "Teilstring ab Position:";
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(12, 19);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 73;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 71);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 72;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdAnzeigen
            // 
            this.CmdAnzeigen.Location = new System.Drawing.Point(12, 207);
            this.CmdAnzeigen.Name = "CmdAnzeigen";
            this.CmdAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen.TabIndex = 71;
            this.CmdAnzeigen.Text = "Anzeigen";
            this.CmdAnzeigen.UseVisualStyleBackColor = true;
            this.CmdAnzeigen.Click += new System.EventHandler(this.CmdAnzeigen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 35);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(150, 20);
            this.TxtEingabe.TabIndex = 70;
            this.TxtEingabe.TextChanged += new System.EventHandler(this.TxtEingabe_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NumPosition);
            this.Controls.Add(this.LblLaenge);
            this.Controls.Add(this.NumLaenge);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeigen);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Teilzeichenkette";
            ((System.ComponentModel.ISupportInitialize)(this.NumPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLaenge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown NumPosition;
        internal System.Windows.Forms.Label LblLaenge;
        internal System.Windows.Forms.NumericUpDown NumLaenge;
        internal System.Windows.Forms.Label LblPosition;
        internal System.Windows.Forms.Label LblEingabe;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdAnzeigen;
        internal System.Windows.Forms.TextBox TxtEingabe;
    }
}

