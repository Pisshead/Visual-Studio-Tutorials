namespace StandardDialogfelder
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdFontDialog = new System.Windows.Forms.Button();
            this.CmdColorDialog = new System.Windows.Forms.Button();
            this.CmdFolderBrowserDialog = new System.Windows.Forms.Button();
            this.CmdSaveFileDialog = new System.Windows.Forms.Button();
            this.CmdOpenFileDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(19, 165);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(112, 13);
            this.LblAnzeige.TabIndex = 29;
            this.LblAnzeige.Text = "Das ist ein Beispieltext";
            // 
            // CmdFontDialog
            // 
            this.CmdFontDialog.Location = new System.Drawing.Point(12, 128);
            this.CmdFontDialog.Name = "CmdFontDialog";
            this.CmdFontDialog.Size = new System.Drawing.Size(150, 23);
            this.CmdFontDialog.TabIndex = 28;
            this.CmdFontDialog.Text = "Font Dialog";
            this.CmdFontDialog.UseVisualStyleBackColor = true;
            this.CmdFontDialog.Click += new System.EventHandler(this.CmdFontDialog_Click);
            // 
            // CmdColorDialog
            // 
            this.CmdColorDialog.Location = new System.Drawing.Point(12, 99);
            this.CmdColorDialog.Name = "CmdColorDialog";
            this.CmdColorDialog.Size = new System.Drawing.Size(150, 23);
            this.CmdColorDialog.TabIndex = 27;
            this.CmdColorDialog.Text = "Color Dialog";
            this.CmdColorDialog.UseVisualStyleBackColor = true;
            this.CmdColorDialog.Click += new System.EventHandler(this.CmdColorDialog_Click);
            // 
            // CmdFolderBrowserDialog
            // 
            this.CmdFolderBrowserDialog.Location = new System.Drawing.Point(12, 70);
            this.CmdFolderBrowserDialog.Name = "CmdFolderBrowserDialog";
            this.CmdFolderBrowserDialog.Size = new System.Drawing.Size(150, 23);
            this.CmdFolderBrowserDialog.TabIndex = 26;
            this.CmdFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.CmdFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.CmdFolderBrowserDialog.Click += new System.EventHandler(this.CmdFolderBrowserDialog_Click);
            // 
            // CmdSaveFileDialog
            // 
            this.CmdSaveFileDialog.Location = new System.Drawing.Point(12, 41);
            this.CmdSaveFileDialog.Name = "CmdSaveFileDialog";
            this.CmdSaveFileDialog.Size = new System.Drawing.Size(150, 23);
            this.CmdSaveFileDialog.TabIndex = 25;
            this.CmdSaveFileDialog.Text = "Save File Dialog";
            this.CmdSaveFileDialog.UseVisualStyleBackColor = true;
            this.CmdSaveFileDialog.Click += new System.EventHandler(this.CmdSaveFileDialog_Click);
            // 
            // CmdOpenFileDialog
            // 
            this.CmdOpenFileDialog.Location = new System.Drawing.Point(12, 12);
            this.CmdOpenFileDialog.Name = "CmdOpenFileDialog";
            this.CmdOpenFileDialog.Size = new System.Drawing.Size(150, 23);
            this.CmdOpenFileDialog.TabIndex = 24;
            this.CmdOpenFileDialog.Text = "Open File Dialog";
            this.CmdOpenFileDialog.UseVisualStyleBackColor = true;
            this.CmdOpenFileDialog.Click += new System.EventHandler(this.CmdOpenFileDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdFontDialog);
            this.Controls.Add(this.CmdColorDialog);
            this.Controls.Add(this.CmdFolderBrowserDialog);
            this.Controls.Add(this.CmdSaveFileDialog);
            this.Controls.Add(this.CmdOpenFileDialog);
            this.Name = "Form1";
            this.Text = "Standard-Dialogfelder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdFontDialog;
        internal System.Windows.Forms.Button CmdColorDialog;
        internal System.Windows.Forms.Button CmdFolderBrowserDialog;
        internal System.Windows.Forms.Button CmdSaveFileDialog;
        internal System.Windows.Forms.Button CmdOpenFileDialog;
    }
}

