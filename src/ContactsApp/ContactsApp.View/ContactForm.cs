using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        private Contact _contact = new Contact(ObjectFactory.GetFullName(), ObjectFactory.GetPhoneNumber(),
           ObjectFactory.GetEmail(), ObjectFactory.GetDateOfBirth(), ObjectFactory.GetVkID());

        private string _fullNameTextBoxError = "";

        private string _emailTextBoxError = "";

        private string _phoneNumberMaskedTextBoxError = "";

        private string _DateOfBirthPickerError = "";

        private string _VKTextBoxError = "";

        private bool CheckFormOnErrors()
        {
            bool error = false;
            if (_fullNameTextBoxError.Length != 0)
            {
                MessageBox.Show(_emailTextBoxError);
                error = true;
            }
            if (_emailTextBoxError.Length != 0)
            {
                MessageBox.Show(_emailTextBoxError);
                error = true;
            }
            if (_phoneNumberMaskedTextBoxError.Length != 0)
            {
                MessageBox.Show(_phoneNumberMaskedTextBoxError);
                error = true;
            }
            if (_DateOfBirthPickerError.Length != 0)
            {
                MessageBox.Show(_DateOfBirthPickerError);
                error = true;
            }
            if (_VKTextBoxError.Length != 0)
            {
                MessageBox.Show(_VKTextBoxError);
                error = true;
            }
            return !error;
        }

        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.DateOfBirth = DateOfBirthPicker.Value;
            _contact.PhoneNumber = PhoneNumberMaskedTextBox1.Text;
            _contact.VkID = VKTextBox.Text;
        }
        public ContactForm()
        {
            InitializeComponent();

            UpdateForm();
        }

        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberMaskedTextBox1.Text = _contact.PhoneNumber;
            DateOfBirthPicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkID;

        }

        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = Color.White;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
                UpdateContact();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
                _fullNameTextBoxError = "";
            }
            catch (ArgumentException exception)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _fullNameTextBoxError = exception.Message;
            }
            
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                _emailTextBoxError = "";
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailTextBoxError = exception.Message;
            }
        }

        private void PhoneNumberMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = PhoneNumberMaskedTextBox1.Text;
                PhoneNumberMaskedTextBox1.BackColor = Color.White;
                _phoneNumberMaskedTextBoxError = "";
            }
            catch (ArgumentException exception)
            {
                PhoneNumberMaskedTextBox1.BackColor = Color.LightPink;
                _phoneNumberMaskedTextBoxError = exception.Message;
            }
        }

        private void DateOfBirthPicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthPicker.Value;
                DateOfBirthPicker.BackColor = Color.White;
                _DateOfBirthPickerError = "";
            }
            catch (ArgumentException exception)
            {
                DateOfBirthPicker.BackColor = Color.LightPink;
                _DateOfBirthPickerError = exception.Message;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkID = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
                _VKTextBoxError = "";
            }
            catch (ArgumentException exception)
            {
                VKTextBox.BackColor = Color.LightPink;
                _VKTextBoxError = exception.Message;
            }
        }

    }
}
