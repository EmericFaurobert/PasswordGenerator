
namespace PasswordGenerator
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutLabel = new System.Windows.Forms.Label();
            this.versionsTextBox = new System.Windows.Forms.TextBox();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.Location = new System.Drawing.Point(9, 9);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(263, 33);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Password Generator is your favorite local app to create new passwords depending o" +
    "n your needs !\r\n\r\n";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionsTextBox
            // 
            this.versionsTextBox.Location = new System.Drawing.Point(12, 101);
            this.versionsTextBox.Multiline = true;
            this.versionsTextBox.Name = "versionsTextBox";
            this.versionsTextBox.ReadOnly = true;
            this.versionsTextBox.Size = new System.Drawing.Size(260, 98);
            this.versionsTextBox.TabIndex = 1;
            this.versionsTextBox.Text = "- Version 1.0 (03/10/2023) : Version initiale";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(74, 66);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(177, 13);
            this.githubLink.TabIndex = 2;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/EmericFaurobert";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(36, 53);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(124, 26);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Author: Emeric Faurobert\r\nGithub: ";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.versionsTextBox);
            this.Controls.Add(this.aboutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.TextBox versionsTextBox;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label authorLabel;
    }
}