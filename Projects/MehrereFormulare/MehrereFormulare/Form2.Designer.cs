namespace MehrereFormulare
{
    partial class Form2
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
            this.TxtUnter = new System.Windows.Forms.TextBox();
            this.ChkUnter = new System.Windows.Forms.CheckBox();
            this.CmdEndeUnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUnter
            // 
            this.TxtUnter.Location = new System.Drawing.Point(12, 42);
            this.TxtUnter.Name = "TxtUnter";
            this.TxtUnter.Size = new System.Drawing.Size(100, 20);
            this.TxtUnter.TabIndex = 16;
            // 
            // ChkUnter
            // 
            this.ChkUnter.AutoSize = true;
            this.ChkUnter.Location = new System.Drawing.Point(12, 68);
            this.ChkUnter.Name = "ChkUnter";
            this.ChkUnter.Size = new System.Drawing.Size(141, 17);
            this.ChkUnter.TabIndex = 15;
            this.ChkUnter.Text = "CheckBox Unterformular";
            this.ChkUnter.UseVisualStyleBackColor = true;
            // 
            // CmdEndeUnter
            // 
            this.CmdEndeUnter.Location = new System.Drawing.Point(12, 91);
            this.CmdEndeUnter.Name = "CmdEndeUnter";
            this.CmdEndeUnter.Size = new System.Drawing.Size(150, 23);
            this.CmdEndeUnter.TabIndex = 14;
            this.CmdEndeUnter.Text = "Ende Unterformular";
            this.CmdEndeUnter.UseVisualStyleBackColor = true;
            this.CmdEndeUnter.Click += new System.EventHandler(this.CmdEndeUnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtUnter);
            this.Controls.Add(this.ChkUnter);
            this.Controls.Add(this.CmdEndeUnter);
            this.Name = "Form2";
            this.Text = "Unterformular";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUnter;
        private System.Windows.Forms.CheckBox ChkUnter;
        private System.Windows.Forms.Button CmdEndeUnter;
    }
}