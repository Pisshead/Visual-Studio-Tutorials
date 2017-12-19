namespace EingabeAusgabe
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
            this.CmdLotto = new System.Windows.Forms.Button();
            this.CmdMsgBoxInformation = new System.Windows.Forms.Button();
            this.CmdMsgBoxRetryCancel = new System.Windows.Forms.Button();
            this.CmdMsgBoxAbortRetryIgnore = new System.Windows.Forms.Button();
            this.CmdMsgBoxYesNoCancel = new System.Windows.Forms.Button();
            this.CmdMsgBoxYesNo = new System.Windows.Forms.Button();
            this.CmdMsgBoxOkOnly = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdLotto
            // 
            this.CmdLotto.Location = new System.Drawing.Point(152, 56);
            this.CmdLotto.Name = "CmdLotto";
            this.CmdLotto.Size = new System.Drawing.Size(120, 23);
            this.CmdLotto.TabIndex = 52;
            this.CmdLotto.Text = "Lotto";
            this.CmdLotto.UseVisualStyleBackColor = true;
            this.CmdLotto.Click += new System.EventHandler(this.CmdLotto_Click);
            // 
            // CmdMsgBoxInformation
            // 
            this.CmdMsgBoxInformation.Location = new System.Drawing.Point(12, 143);
            this.CmdMsgBoxInformation.Name = "CmdMsgBoxInformation";
            this.CmdMsgBoxInformation.Size = new System.Drawing.Size(120, 23);
            this.CmdMsgBoxInformation.TabIndex = 51;
            this.CmdMsgBoxInformation.Text = "Information";
            this.CmdMsgBoxInformation.UseVisualStyleBackColor = true;
            this.CmdMsgBoxInformation.Click += new System.EventHandler(this.CmdMsgBoxInformation_Click);
            // 
            // CmdMsgBoxRetryCancel
            // 
            this.CmdMsgBoxRetryCancel.Location = new System.Drawing.Point(152, 172);
            this.CmdMsgBoxRetryCancel.Name = "CmdMsgBoxRetryCancel";
            this.CmdMsgBoxRetryCancel.Size = new System.Drawing.Size(120, 23);
            this.CmdMsgBoxRetryCancel.TabIndex = 50;
            this.CmdMsgBoxRetryCancel.Text = "Retry Cancel";
            this.CmdMsgBoxRetryCancel.UseVisualStyleBackColor = true;
            this.CmdMsgBoxRetryCancel.Click += new System.EventHandler(this.CmdMsgBoxRetryCancel_Click);
            // 
            // CmdMsgBoxAbortRetryIgnore
            // 
            this.CmdMsgBoxAbortRetryIgnore.Location = new System.Drawing.Point(152, 201);
            this.CmdMsgBoxAbortRetryIgnore.Name = "CmdMsgBoxAbortRetryIgnore";
            this.CmdMsgBoxAbortRetryIgnore.Size = new System.Drawing.Size(120, 23);
            this.CmdMsgBoxAbortRetryIgnore.TabIndex = 49;
            this.CmdMsgBoxAbortRetryIgnore.Text = "Abort Retry Ignore";
            this.CmdMsgBoxAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.CmdMsgBoxAbortRetryIgnore.Click += new System.EventHandler(this.CmdMsgBoxAbortRetryIgnore_Click);
            // 
            // CmdMsgBoxYesNoCancel
            // 
            this.CmdMsgBoxYesNoCancel.Location = new System.Drawing.Point(152, 143);
            this.CmdMsgBoxYesNoCancel.Name = "CmdMsgBoxYesNoCancel";
            this.CmdMsgBoxYesNoCancel.Size = new System.Drawing.Size(120, 23);
            this.CmdMsgBoxYesNoCancel.TabIndex = 48;
            this.CmdMsgBoxYesNoCancel.Text = "Yes No Cancel";
            this.CmdMsgBoxYesNoCancel.UseVisualStyleBackColor = true;
            this.CmdMsgBoxYesNoCancel.Click += new System.EventHandler(this.CmdMsgBoxYesNoCancel_Click);
            // 
            // CmdMsgBoxYesNo
            // 
            this.CmdMsgBoxYesNo.Location = new System.Drawing.Point(152, 114);
            this.CmdMsgBoxYesNo.Name = "CmdMsgBoxYesNo";
            this.CmdMsgBoxYesNo.Size = new System.Drawing.Size(120, 23);
            this.CmdMsgBoxYesNo.TabIndex = 47;
            this.CmdMsgBoxYesNo.Text = "Yes No";
            this.CmdMsgBoxYesNo.UseVisualStyleBackColor = true;
            this.CmdMsgBoxYesNo.Click += new System.EventHandler(this.CmdMsgBoxYesNo_Click);
            // 
            // CmdMsgBoxOkOnly
            // 
            this.CmdMsgBoxOkOnly.Location = new System.Drawing.Point(12, 114);
            this.CmdMsgBoxOkOnly.Name = "CmdMsgBoxOkOnly";
            this.CmdMsgBoxOkOnly.Size = new System.Drawing.Size(120, 23);
            this.CmdMsgBoxOkOnly.TabIndex = 46;
            this.CmdMsgBoxOkOnly.Text = "Ok";
            this.CmdMsgBoxOkOnly.UseVisualStyleBackColor = true;
            this.CmdMsgBoxOkOnly.Click += new System.EventHandler(this.CmdMsgBoxOkOnly_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 20);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 45;
            // 
            // CmdInput
            // 
            this.CmdInput.Location = new System.Drawing.Point(12, 56);
            this.CmdInput.Name = "CmdInput";
            this.CmdInput.Size = new System.Drawing.Size(120, 23);
            this.CmdInput.TabIndex = 44;
            this.CmdInput.Text = "Input";
            this.CmdInput.UseVisualStyleBackColor = true;
            this.CmdInput.Click += new System.EventHandler(this.CmdInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdLotto);
            this.Controls.Add(this.CmdMsgBoxInformation);
            this.Controls.Add(this.CmdMsgBoxRetryCancel);
            this.Controls.Add(this.CmdMsgBoxAbortRetryIgnore);
            this.Controls.Add(this.CmdMsgBoxYesNoCancel);
            this.Controls.Add(this.CmdMsgBoxYesNo);
            this.Controls.Add(this.CmdMsgBoxOkOnly);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdInput);
            this.Name = "Form1";
            this.Text = "Eingabe und Ausgabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdLotto;
        internal System.Windows.Forms.Button CmdMsgBoxInformation;
        internal System.Windows.Forms.Button CmdMsgBoxRetryCancel;
        internal System.Windows.Forms.Button CmdMsgBoxAbortRetryIgnore;
        internal System.Windows.Forms.Button CmdMsgBoxYesNoCancel;
        internal System.Windows.Forms.Button CmdMsgBoxYesNo;
        internal System.Windows.Forms.Button CmdMsgBoxOkOnly;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdInput;
    }
}

