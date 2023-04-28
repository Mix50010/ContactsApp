namespace ContactsApp.View
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
            this.OKPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorDataLabel = new System.Windows.Forms.Label();
            this.EmailDataLabel = new System.Windows.Forms.Label();
            this.IconsLabel = new System.Windows.Forms.Label();
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.IconsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OKPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKPanel
            // 
            this.OKPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKPanel.Controls.Add(this.OKButton);
            this.OKPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKPanel.Location = new System.Drawing.Point(0, 338);
            this.OKPanel.Name = "OKPanel";
            this.OKPanel.Size = new System.Drawing.Size(512, 50);
            this.OKPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(425, 15);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 78);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 102);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-mail:";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Location = new System.Drawing.Point(12, 125);
            this.GitLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(41, 13);
            this.GitLabel.TabIndex = 3;
            this.GitLabel.Text = "Github:";
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.BackColor = System.Drawing.Color.White;
            this.LicenseTextBox.Location = new System.Drawing.Point(15, 148);
            this.LicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LicenseTextBox.Multiline = true;
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.ReadOnly = true;
            this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenseTextBox.Size = new System.Drawing.Size(484, 155);
            this.LicenseTextBox.TabIndex = 5;
            this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 19);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(160, 29);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 48);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 13);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "v 1.0";
            // 
            // AuthorDataLabel
            // 
            this.AuthorDataLabel.AutoSize = true;
            this.AuthorDataLabel.Location = new System.Drawing.Point(108, 78);
            this.AuthorDataLabel.Name = "AuthorDataLabel";
            this.AuthorDataLabel.Size = new System.Drawing.Size(92, 13);
            this.AuthorDataLabel.TabIndex = 8;
            this.AuthorDataLabel.Text = "Goryachev Maxim";
            // 
            // EmailDataLabel
            // 
            this.EmailDataLabel.AutoSize = true;
            this.EmailDataLabel.Location = new System.Drawing.Point(108, 102);
            this.EmailDataLabel.Name = "EmailDataLabel";
            this.EmailDataLabel.Size = new System.Drawing.Size(147, 13);
            this.EmailDataLabel.TabIndex = 9;
            this.EmailDataLabel.Text = "goryachev.maxim@gmail.com";
            // 
            // IconsLabel
            // 
            this.IconsLabel.AutoSize = true;
            this.IconsLabel.Location = new System.Drawing.Point(12, 310);
            this.IconsLabel.Name = "IconsLabel";
            this.IconsLabel.Size = new System.Drawing.Size(182, 13);
            this.IconsLabel.TabIndex = 11;
            this.IconsLabel.Text = "All used images are downloaded from";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Location = new System.Drawing.Point(108, 125);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(146, 13);
            this.GitLinkLabel.TabIndex = 12;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "https://github.com/Mix50010";
            // 
            // IconsLinkLabel
            // 
            this.IconsLinkLabel.AutoSize = true;
            this.IconsLinkLabel.Location = new System.Drawing.Point(193, 310);
            this.IconsLinkLabel.Name = "IconsLinkLabel";
            this.IconsLinkLabel.Size = new System.Drawing.Size(61, 13);
            this.IconsLinkLabel.TabIndex = 13;
            this.IconsLinkLabel.TabStop = true;
            this.IconsLinkLabel.Text = "icons8.com";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 388);
            this.ControlBox = false;
            this.Controls.Add(this.IconsLinkLabel);
            this.Controls.Add(this.GitLinkLabel);
            this.Controls.Add(this.IconsLabel);
            this.Controls.Add(this.EmailDataLabel);
            this.Controls.Add(this.AuthorDataLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.OKPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.OKPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OKPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorDataLabel;
        private System.Windows.Forms.Label EmailDataLabel;
        private System.Windows.Forms.Label IconsLabel;
        private System.Windows.Forms.LinkLabel GitLinkLabel;
        private System.Windows.Forms.LinkLabel IconsLinkLabel;
        private System.Windows.Forms.TextBox LicenseTextBox;
    }
}