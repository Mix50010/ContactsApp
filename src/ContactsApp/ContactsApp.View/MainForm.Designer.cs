namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.createButtonContact = new System.Windows.Forms.Button();
            this.editContactButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.vkLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifyDynamicLabel = new System.Windows.Forms.Label();
            this.notifyStaticLabel = new System.Windows.Forms.Label();
            this.notifyPictureBox = new System.Windows.Forms.PictureBox();
            this.notifyCancelPictureBox = new System.Windows.Forms.Button();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.deleteContactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(12, 9);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(30, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(48, 6);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(100, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.photoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.photoPictureBox.Location = new System.Drawing.Point(265, 39);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.photoPictureBox.TabIndex = 2;
            this.photoPictureBox.TabStop = false;
            // 
            // createButtonContact
            // 
            this.createButtonContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createButtonContact.AutoSize = true;
            this.createButtonContact.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.createButtonContact.Location = new System.Drawing.Point(12, 409);
            this.createButtonContact.Name = "createButtonContact";
            this.createButtonContact.Size = new System.Drawing.Size(75, 38);
            this.createButtonContact.TabIndex = 3;
            this.createButtonContact.UseVisualStyleBackColor = true;
            this.createButtonContact.Click += new System.EventHandler(this.button1_Click);
            this.createButtonContact.MouseEnter += new System.EventHandler(this.createButtonContact_MouseEnter);
            this.createButtonContact.MouseLeave += new System.EventHandler(this.createButtonContact_MouseLeave);
            // 
            // editContactButton
            // 
            this.editContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editContactButton.AutoSize = true;
            this.editContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.editContactButton.Location = new System.Drawing.Point(93, 409);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(75, 38);
            this.editContactButton.TabIndex = 4;
            this.editContactButton.UseVisualStyleBackColor = true;
            this.editContactButton.MouseEnter += new System.EventHandler(this.editContactButton_MouseEnter);
            this.editContactButton.MouseLeave += new System.EventHandler(this.editContactButton_MouseLeave);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(371, 39);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 6;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(371, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "E-mail:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(371, 117);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "PhoneNumber:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(371, 156);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 9;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // vkLabel
            // 
            this.vkLabel.AutoSize = true;
            this.vkLabel.Location = new System.Drawing.Point(371, 195);
            this.vkLabel.Name = "vkLabel";
            this.vkLabel.Size = new System.Drawing.Size(24, 13);
            this.vkLabel.TabIndex = 10;
            this.vkLabel.Text = "VK:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(371, 55);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.fullNameTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(374, 94);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(357, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(374, 133);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.phoneNumberTextBox.TabIndex = 13;
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(374, 172);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(180, 20);
            this.dateOfBirthTextBox.TabIndex = 14;
            // 
            // vkTextBox
            // 
            this.vkTextBox.Location = new System.Drawing.Point(374, 211);
            this.vkTextBox.Name = "vkTextBox";
            this.vkTextBox.Size = new System.Drawing.Size(180, 20);
            this.vkTextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.notifyDynamicLabel);
            this.groupBox1.Controls.Add(this.notifyStaticLabel);
            this.groupBox1.Controls.Add(this.notifyPictureBox);
            this.groupBox1.Controls.Add(this.notifyCancelPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(265, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(503, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // notifyDynamicLabel
            // 
            this.notifyDynamicLabel.AutoSize = true;
            this.notifyDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyDynamicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.notifyDynamicLabel.Location = new System.Drawing.Point(62, 52);
            this.notifyDynamicLabel.Name = "notifyDynamicLabel";
            this.notifyDynamicLabel.Size = new System.Drawing.Size(63, 13);
            this.notifyDynamicLabel.TabIndex = 3;
            this.notifyDynamicLabel.Text = "MockText";
            // 
            // notifyStaticLabel
            // 
            this.notifyStaticLabel.AutoSize = true;
            this.notifyStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyStaticLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.notifyStaticLabel.Location = new System.Drawing.Point(60, 37);
            this.notifyStaticLabel.Name = "notifyStaticLabel";
            this.notifyStaticLabel.Size = new System.Drawing.Size(135, 13);
            this.notifyStaticLabel.TabIndex = 2;
            this.notifyStaticLabel.Text = "Today is a Birthday of:";
            // 
            // notifyPictureBox
            // 
            this.notifyPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.notifyPictureBox.Location = new System.Drawing.Point(6, 37);
            this.notifyPictureBox.Name = "notifyPictureBox";
            this.notifyPictureBox.Size = new System.Drawing.Size(48, 48);
            this.notifyPictureBox.TabIndex = 1;
            this.notifyPictureBox.TabStop = false;
            // 
            // notifyCancelPictureBox
            // 
            this.notifyCancelPictureBox.BackgroundImage = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.notifyCancelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notifyCancelPictureBox.FlatAppearance.BorderSize = 0;
            this.notifyCancelPictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyCancelPictureBox.Location = new System.Drawing.Point(465, 9);
            this.notifyCancelPictureBox.Name = "notifyCancelPictureBox";
            this.notifyCancelPictureBox.Size = new System.Drawing.Size(32, 32);
            this.notifyCancelPictureBox.TabIndex = 0;
            this.notifyCancelPictureBox.UseVisualStyleBackColor = true;
            // 
            // contactsListBox
            // 
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.Location = new System.Drawing.Point(15, 39);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(234, 355);
            this.contactsListBox.TabIndex = 17;
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteContactButton.AutoSize = true;
            this.deleteContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.deleteContactButton.Location = new System.Drawing.Point(174, 409);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(75, 38);
            this.deleteContactButton.TabIndex = 5;
            this.deleteContactButton.UseVisualStyleBackColor = true;
            this.deleteContactButton.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.deleteContactButton.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vkTextBox);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.vkLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.deleteContactButton);
            this.Controls.Add(this.editContactButton);
            this.Controls.Add(this.createButtonContact);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button createButtonContact;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox notifyPictureBox;
        private System.Windows.Forms.Button notifyCancelPictureBox;
        private System.Windows.Forms.Label notifyDynamicLabel;
        private System.Windows.Forms.Label notifyStaticLabel;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.Button deleteContactButton;
    }
}

