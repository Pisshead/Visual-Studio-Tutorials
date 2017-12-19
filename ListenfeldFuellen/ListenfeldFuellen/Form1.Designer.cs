namespace ListenfeldFuellen
{
    partial class Form1
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
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(13, 13);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 43);
            this.LstSpeisen.TabIndex = 0;
            this.LstSpeisen.SelectedIndexChanged += new System.EventHandler(this.LstSpeisen_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
    }
}

