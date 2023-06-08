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
        /// <summary>
        /// Экземпляр контакта.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Поле ошибки для имени.
        /// </summary>
        private string _fullNameTextBoxError = "";

        /// <summary>
        /// Поле ошибки для емайла.
        /// </summary>  
        private string _emailTextBoxError = "";

        /// <summary>
        /// Поле ошибки для номера.
        /// </summary>
        private string _phoneNumberMaskedTextBoxError = "";

        /// <summary>
        /// Поле ошибки для даты рождения.
        /// </summary>
        private string _DateOfBirthPickerError = "";

        /// <summary>
        /// Поле ошибки для Вк.
        /// </summary>
        private string _VKTextBoxError = "";
        
        /// <summary>
        /// Свойства контакта.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                UpdateForm();
            }
        }

        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public ContactForm()
        {
            _contact = new Contact();
            
            InitializeComponent();

            _fullNameTextBoxError = "Имя не должно быть пустым!";
            _emailTextBoxError = "Почта не должно быть пустым!";
            _DateOfBirthPickerError = "Дата рождения не должно быть пустым!";
            _phoneNumberMaskedTextBoxError = "Номер телефона не должно быть пустым!";
            _VKTextBoxError = "ВК не должно быть пустым!";
        }


        /// <summary>
        /// Проверка формы на ошибки во вводе.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            bool isError = false;
            string errorText = "";
            if (_fullNameTextBoxError != "")
            {
                errorText += _fullNameTextBoxError + "\n";
                isError = true;
            }
            if (_emailTextBoxError.Length != 0)
            {
                errorText += _emailTextBoxError + "\n";
                isError = true;
            }
            if (_phoneNumberMaskedTextBoxError.Length != 0)
            {
                errorText += _phoneNumberMaskedTextBoxError + "\n";
                isError = true;
            }
            if (_DateOfBirthPickerError.Length != 0)
            {
                errorText += _DateOfBirthPickerError + "\n";
                isError = true;
            }
            if (_VKTextBoxError.Length != 0)
            {
                errorText += _VKTextBoxError + "\n";
                isError = true;
            }
            if (isError)
                MessageBox.Show(errorText);
            return !isError;
        }

        /// <summary>
        /// Обновление текущего контакта.
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.DateOfBirth = DateOfBirthPicker.Value;
            _contact.PhoneNumber = PhoneNumberMaskedTextBox1.Text;
            _contact.VkID = VKTextBox.Text;
        }
        /// <summary>
        /// Обновление информации на форме.
        /// </summary>
        /// 
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberMaskedTextBox1.Text = _contact.PhoneNumber;
            DateOfBirthPicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkID;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = Color.White;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Валидация и завершение редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                UpdateContact();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }   
        }

        /// <summary>
        /// Валидация имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Валидация емайла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Валидация номера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Валидация даты рождения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Валидация Вк.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
