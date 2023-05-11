namespace ContactsApp.View
{
    partial class ContactForm
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
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.OKPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.PhoneNumberMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.OKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BackgroundImage = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(121, 225);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(180, 20);
            this.VKTextBox.TabIndex = 25;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(121, 78);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(360, 20);
            this.EmailTextBox.TabIndex = 22;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(121, 29);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.FullNameTextBox.TabIndex = 21;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(118, 209);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 20;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 160);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 19;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 111);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 18;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 62);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 12);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 16;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Location = new System.Drawing.Point(121, 176);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(180, 20);
            this.DateOfBirthPicker.TabIndex = 27;
            this.DateOfBirthPicker.ValueChanged += new System.EventHandler(this.DateOfBirthPicker_ValueChanged);
            // 
            // OKPanel
            // 
            this.OKPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKPanel.Controls.Add(this.CancelButton);
            this.OKPanel.Controls.Add(this.OKButton);
            this.OKPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKPanel.Location = new System.Drawing.Point(0, 261);
            this.OKPanel.Name = "OKPanel";
            this.OKPanel.Size = new System.Drawing.Size(493, 49);
            this.OKPanel.TabIndex = 28;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(406, 14);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(325, 14);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(46, 118);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoButton.TabIndex = 2;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            // 
            // PhoneNumberMaskedTextBox1
            // 
            this.PhoneNumberMaskedTextBox1.Location = new System.Drawing.Point(121, 130);
            this.PhoneNumberMaskedTextBox1.Mask = "+7 (000) 000-0000";
            this.PhoneNumberMaskedTextBox1.Name = "PhoneNumberMaskedTextBox1";
            this.PhoneNumberMaskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberMaskedTextBox1.TabIndex = 29;
            this.PhoneNumberMaskedTextBox1.TextChanged += new System.EventHandler(this.PhoneNumberMaskedTextBox1_TextChanged);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 310);
            this.Controls.Add(this.PhoneNumberMaskedTextBox1);
            this.Controls.Add(this.AddPhotoButton);
            this.Controls.Add(this.OKPanel);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.VKTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Name = "ContactForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.OKPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Panel OKPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.PictureBox AddPhotoButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox1;
    }
}