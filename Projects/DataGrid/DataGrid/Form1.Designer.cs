namespace DataGrid
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
            this.CmdInfoSpalte = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdMittelwert = new System.Windows.Forms.Button();
            this.DgvPersonen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdInfoSpalte
            // 
            this.CmdInfoSpalte.Location = new System.Drawing.Point(12, 171);
            this.CmdInfoSpalte.Name = "CmdInfoSpalte";
            this.CmdInfoSpalte.Size = new System.Drawing.Size(75, 23);
            this.CmdInfoSpalte.TabIndex = 15;
            this.CmdInfoSpalte.Text = "Info Spalte";
            this.CmdInfoSpalte.UseVisualStyleBackColor = true;
            this.CmdInfoSpalte.Click += new System.EventHandler(this.CmdInfoSpalte_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(133, 176);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 14;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdMittelwert
            // 
            this.CmdMittelwert.Location = new System.Drawing.Point(12, 200);
            this.CmdMittelwert.Name = "CmdMittelwert";
            this.CmdMittelwert.Size = new System.Drawing.Size(75, 23);
            this.CmdMittelwert.TabIndex = 13;
            this.CmdMittelwert.Text = "Mittelwert";
            this.CmdMittelwert.UseVisualStyleBackColor = true;
            this.CmdMittelwert.Click += new System.EventHandler(this.CmdMittelwert_Click);
            // 
            // DgvPersonen
            // 
            this.DgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonen.Location = new System.Drawing.Point(12, 12);
            this.DgvPersonen.Name = "DgvPersonen";
            this.DgvPersonen.Size = new System.Drawing.Size(460, 150);
            this.DgvPersonen.TabIndex = 12;
            this.DgvPersonen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonen_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.CmdInfoSpalte);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdMittelwert);
            this.Controls.Add(this.DgvPersonen);
            this.Name = "Form1";
            this.Text = "DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdInfoSpalte;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdMittelwert;
        internal System.Windows.Forms.DataGridView DgvPersonen;
    }
}

