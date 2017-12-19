namespace Listenansicht
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
            this.OptTile = new System.Windows.Forms.RadioButton();
            this.OptSmallIcon = new System.Windows.Forms.RadioButton();
            this.OptList = new System.Windows.Forms.RadioButton();
            this.OptLargeIcon = new System.Windows.Forms.RadioButton();
            this.OptDetails = new System.Windows.Forms.RadioButton();
            this.LView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // OptTile
            // 
            this.OptTile.AutoSize = true;
            this.OptTile.Location = new System.Drawing.Point(340, 99);
            this.OptTile.Margin = new System.Windows.Forms.Padding(2);
            this.OptTile.Name = "OptTile";
            this.OptTile.Size = new System.Drawing.Size(42, 17);
            this.OptTile.TabIndex = 23;
            this.OptTile.Text = "Tile";
            this.OptTile.UseVisualStyleBackColor = true;
            this.OptTile.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptSmallIcon
            // 
            this.OptSmallIcon.AutoSize = true;
            this.OptSmallIcon.Location = new System.Drawing.Point(340, 77);
            this.OptSmallIcon.Margin = new System.Windows.Forms.Padding(2);
            this.OptSmallIcon.Name = "OptSmallIcon";
            this.OptSmallIcon.Size = new System.Drawing.Size(71, 17);
            this.OptSmallIcon.TabIndex = 22;
            this.OptSmallIcon.Text = "SmallIcon";
            this.OptSmallIcon.UseVisualStyleBackColor = true;
            this.OptSmallIcon.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptList
            // 
            this.OptList.AutoSize = true;
            this.OptList.Location = new System.Drawing.Point(340, 55);
            this.OptList.Margin = new System.Windows.Forms.Padding(2);
            this.OptList.Name = "OptList";
            this.OptList.Size = new System.Drawing.Size(41, 17);
            this.OptList.TabIndex = 21;
            this.OptList.Text = "List";
            this.OptList.UseVisualStyleBackColor = true;
            this.OptList.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptLargeIcon
            // 
            this.OptLargeIcon.AutoSize = true;
            this.OptLargeIcon.Location = new System.Drawing.Point(340, 33);
            this.OptLargeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.OptLargeIcon.Name = "OptLargeIcon";
            this.OptLargeIcon.Size = new System.Drawing.Size(73, 17);
            this.OptLargeIcon.TabIndex = 20;
            this.OptLargeIcon.Text = "LargeIcon";
            this.OptLargeIcon.UseVisualStyleBackColor = true;
            this.OptLargeIcon.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // OptDetails
            // 
            this.OptDetails.AutoSize = true;
            this.OptDetails.Checked = true;
            this.OptDetails.Location = new System.Drawing.Point(340, 11);
            this.OptDetails.Margin = new System.Windows.Forms.Padding(2);
            this.OptDetails.Name = "OptDetails";
            this.OptDetails.Size = new System.Drawing.Size(57, 17);
            this.OptDetails.TabIndex = 19;
            this.OptDetails.TabStop = true;
            this.OptDetails.Text = "Details";
            this.OptDetails.UseVisualStyleBackColor = true;
            this.OptDetails.CheckedChanged += new System.EventHandler(this.OptView_CheckedChanged);
            // 
            // LView
            // 
            this.LView.Location = new System.Drawing.Point(11, 11);
            this.LView.Margin = new System.Windows.Forms.Padding(2);
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(307, 123);
            this.LView.TabIndex = 18;
            this.LView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.OptTile);
            this.Controls.Add(this.OptSmallIcon);
            this.Controls.Add(this.OptList);
            this.Controls.Add(this.OptLargeIcon);
            this.Controls.Add(this.OptDetails);
            this.Controls.Add(this.LView);
            this.Name = "Form1";
            this.Text = "Listenansicht";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton OptTile;
        internal System.Windows.Forms.RadioButton OptSmallIcon;
        internal System.Windows.Forms.RadioButton OptList;
        internal System.Windows.Forms.RadioButton OptLargeIcon;
        internal System.Windows.Forms.RadioButton OptDetails;
        internal System.Windows.Forms.ListView LView;
    }
}

