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
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.PictureBox();
            this.RemoveButton = new System.Windows.Forms.PictureBox();
            this.EditButton = new System.Windows.Forms.PictureBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.ContactsViewPanel = new System.Windows.Forms.Panel();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.CancelNotificationButton = new System.Windows.Forms.PictureBox();
            this.BirthdaySurnamesLabel = new System.Windows.Forms.Label();
            this.BirthdayPanelStaticTextLabel = new System.Windows.Forms.Label();
            this.BirthdayPanelPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.ContactsPanel.SuspendLayout();
            this.ButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).BeginInit();
            this.ContactsViewPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelNotificationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.ContactsPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ContactsViewPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayoutPanel.TabIndex = 18;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.Controls.Add(this.ButtonTableLayoutPanel);
            this.ContactsPanel.Controls.Add(this.FindLabel);
            this.ContactsPanel.Controls.Add(this.FindTextBox);
            this.ContactsPanel.Controls.Add(this.ContactsListBox);
            this.ContactsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsPanel.Location = new System.Drawing.Point(3, 3);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(244, 444);
            this.ContactsPanel.TabIndex = 0;
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonTableLayoutPanel.ColumnCount = 3;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.RemoveButton, 2, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.EditButton, 1, 0);
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(3, 406);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 1;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(238, 35);
            this.ButtonTableLayoutPanel.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(79, 35);
            this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddButton.TabIndex = 4;
            this.AddButton.TabStop = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveButton.Location = new System.Drawing.Point(158, 0);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(80, 35);
            this.RemoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.TabStop = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // EditButton
            // 
            this.EditButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditButton.Location = new System.Drawing.Point(79, 0);
            this.EditButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(79, 35);
            this.EditButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditButton.TabIndex = 3;
            this.EditButton.TabStop = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseEnter += new System.EventHandler(this.EditButton_MouseEnter);
            this.EditButton.MouseLeave += new System.EventHandler(this.EditButton_MouseLeave);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(3, 6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(39, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(202, 20);
            this.FindTextBox.TabIndex = 2;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 29);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 377);
            this.ContactsListBox.TabIndex = 1;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // ContactsViewPanel
            // 
            this.ContactsViewPanel.Controls.Add(this.PhoneNumberTextBox);
            this.ContactsViewPanel.Controls.Add(this.BirthdayPanel);
            this.ContactsViewPanel.Controls.Add(this.VKTextBox);
            this.ContactsViewPanel.Controls.Add(this.VKLabel);
            this.ContactsViewPanel.Controls.Add(this.DateOfBirthTextBox);
            this.ContactsViewPanel.Controls.Add(this.DateOfBirthLabel);
            this.ContactsViewPanel.Controls.Add(this.PhoneNumberLabel);
            this.ContactsViewPanel.Controls.Add(this.EmailTextBox);
            this.ContactsViewPanel.Controls.Add(this.EmailLabel);
            this.ContactsViewPanel.Controls.Add(this.FullNameTextbox);
            this.ContactsViewPanel.Controls.Add(this.FullNameLabel);
            this.ContactsViewPanel.Controls.Add(this.PhotoPictureBox);
            this.ContactsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsViewPanel.Location = new System.Drawing.Point(253, 3);
            this.ContactsViewPanel.Name = "ContactsViewPanel";
            this.ContactsViewPanel.Size = new System.Drawing.Size(544, 444);
            this.ContactsViewPanel.TabIndex = 1;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(112, 127);
            this.PhoneNumberTextBox.Mask = "+7 (000) 000-0000";
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ReadOnly = true;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneNumberTextBox.TabIndex = 30;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.CancelNotificationButton);
            this.BirthdayPanel.Controls.Add(this.BirthdaySurnamesLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelStaticTextLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 341);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(538, 100);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // CancelNotificationButton
            // 
            this.CancelNotificationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelNotificationButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.CancelNotificationButton.Location = new System.Drawing.Point(503, 3);
            this.CancelNotificationButton.Name = "CancelNotificationButton";
            this.CancelNotificationButton.Size = new System.Drawing.Size(32, 32);
            this.CancelNotificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CancelNotificationButton.TabIndex = 3;
            this.CancelNotificationButton.TabStop = false;
            this.CancelNotificationButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BirthdaySurnamesLabel
            // 
            this.BirthdaySurnamesLabel.AutoSize = true;
            this.BirthdaySurnamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdaySurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdaySurnamesLabel.Location = new System.Drawing.Point(106, 54);
            this.BirthdaySurnamesLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            this.BirthdaySurnamesLabel.Size = new System.Drawing.Size(205, 13);
            this.BirthdaySurnamesLabel.TabIndex = 2;
            this.BirthdaySurnamesLabel.Text = "Абакумов, Петров, Иванов  и др.";
            // 
            // BirthdayPanelStaticTextLabel
            // 
            this.BirthdayPanelStaticTextLabel.AutoSize = true;
            this.BirthdayPanelStaticTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayPanelStaticTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayPanelStaticTextLabel.Location = new System.Drawing.Point(106, 31);
            this.BirthdayPanelStaticTextLabel.Name = "BirthdayPanelStaticTextLabel";
            this.BirthdayPanelStaticTextLabel.Size = new System.Drawing.Size(124, 13);
            this.BirthdayPanelStaticTextLabel.TabIndex = 1;
            this.BirthdayPanelStaticTextLabel.Text = "Today is Birthday of:";
            // 
            // BirthdayPanelPictureBox
            // 
            this.BirthdayPanelPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.BirthdayPanelPictureBox.Location = new System.Drawing.Point(3, 3);
            this.BirthdayPanelPictureBox.Name = "BirthdayPanelPictureBox";
            this.BirthdayPanelPictureBox.Size = new System.Drawing.Size(97, 94);
            this.BirthdayPanelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BirthdayPanelPictureBox.TabIndex = 0;
            this.BirthdayPanelPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.BackColor = System.Drawing.Color.White;
            this.VKTextBox.Location = new System.Drawing.Point(112, 218);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.ReadOnly = true;
            this.VKTextBox.Size = new System.Drawing.Size(175, 20);
            this.VKTextBox.TabIndex = 10;
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(109, 202);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.BackColor = System.Drawing.Color.White;
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(112, 169);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.ReadOnly = true;
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(175, 20);
            this.DateOfBirthTextBox.TabIndex = 8;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(109, 153);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(109, 104);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.Location = new System.Drawing.Point(112, 71);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(429, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(109, 55);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-Mail:";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextbox.BackColor = System.Drawing.Color.White;
            this.FullNameTextbox.Location = new System.Drawing.Point(112, 22);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.ReadOnly = true;
            this.FullNameTextbox.Size = new System.Drawing.Size(429, 20);
            this.FullNameTextbox.TabIndex = 2;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(109, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ContactsPanel.ResumeLayout(false);
            this.ContactsPanel.PerformLayout();
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).EndInit();
            this.ContactsViewPanel.ResumeLayout(false);
            this.ContactsViewPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelNotificationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Panel ContactsViewPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label BirthdaySurnamesLabel;
        private System.Windows.Forms.Label BirthdayPanelStaticTextLabel;
        private System.Windows.Forms.PictureBox BirthdayPanelPictureBox;
        private System.Windows.Forms.PictureBox RemoveButton;
        private System.Windows.Forms.PictureBox EditButton;
        private System.Windows.Forms.PictureBox AddButton;
        private System.Windows.Forms.PictureBox CancelNotificationButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
    }
}

