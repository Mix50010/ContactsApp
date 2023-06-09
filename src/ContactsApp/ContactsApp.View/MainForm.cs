using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml.Serialization;
using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Цвет кнопок
        /// </summary>
        static readonly Color CORRECT = Color.White;

        /// <summary>
        /// Цвет при наведении
        /// </summary>
        static readonly Color MOUSEENTER = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");

        /// <summary>
        /// Цвет кнопки удаления при наведении
        /// </summary>
        static readonly Color DELETEMOUSEENTER = System.Drawing.ColorTranslator.FromHtml("#FAF5F5");

        /// <summary> 
        /// Проект. 
        /// </summary>
        private Project _project = new Project();
        /// <summary>
        /// Отображаемые при поиске контакты.
        /// </summary>
        private List<Contact> _currentContacts = new List<Contact>();

        /// <summary>
        /// Менеджер сохраненияэ/загрузки
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        /// <summary> 
        /// Обновляет ЛистБокс с контактами. 
        /// </summary> 
        private void UpdateListBox()
        {
            _currentContacts.Sort();
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _currentContacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }
        
        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        /// <param name="contact"></param>
        private void AddContact(Contact contact)
        {
            _project.Contacts.Add(contact);
        }

        /// <summary>
        /// Обновляет текущий список контактов.
        /// </summary>
        private void UpdateCurrentContacts()
        {
            if (FindTextBox.Text.Length != 0)
            {
                _currentContacts = _project.FindContacts(FindTextBox.Text);
            }
            else
            {
                _currentContacts = _project.Contacts;
            }
        }

        /// <summary> 
        /// Удаляет контакт из проекта. 
        /// </summary> 
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить " + 
                _project.Contacts[index].FullName + "?") == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(index);
            }
        }
        /// <summary> 
        /// Обновляет информацию о текущем выбранном контакте. 
        /// </summary> 
        private void UpdateSelectedContact(int index)
        {
            if (index != -1)
            {
                var currentContact = _currentContacts[index];
                FullNameTextbox.Text = currentContact.FullName;
                EmailTextBox.Text = currentContact.Email;
                PhoneNumberTextBox.Text = currentContact.PhoneNumber;
                DateOfBirthTextBox.Text = currentContact.DateOfBirth.ToLongDateString();
                VKTextBox.Text = currentContact.VkID;
            }
            else
            {
                ClearSelectedContact();
            }
        }

        /// <summary> 
        /// Очищает поля информации о текущем выбранном контакте. 
        /// </summary> 
        private void ClearSelectedContact()
        {
            FullNameTextbox.Clear();
            EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
            DateOfBirthTextBox.Clear();
            VKTextBox.Clear();
        }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = _projectSerializer.LoadFromFile();
            UpdateCurrentContacts();
            UpdateListBox();
        }

        /// <summary>
        /// Вызов изменения контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                var contactForm = new ContactForm();
                contactForm.Contact = _currentContacts[ContactsListBox.SelectedIndex];
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    var newContact = contactForm.Contact;
                    _project.Contacts[_project.Contacts.IndexOf(_currentContacts[ContactsListBox.SelectedIndex])] = newContact;
                    UpdateSelectedContact(ContactsListBox.SelectedIndex);
                    UpdateListBox();
                    _projectSerializer.SaveToFile(_project);
                }
            }
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateCurrentContacts();
            UpdateListBox();
            UpdateSelectedContact(-1);
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Обновление информации о контакте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                ClearSelectedContact();
            }    
            else
            {
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
            }   
        }

        /// <summary>
        /// Фильтрация по поисковому запросу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentContacts();
            UpdateListBox();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _projectSerializer.SaveToFile(_project);
        }


        /// <summary>
        /// Добавление контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var contactForm = new ContactForm();

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                var newContact = contactForm.Contact;
                AddContact(newContact);
                UpdateCurrentContacts();
                UpdateListBox();
                UpdateSelectedContact(ContactsListBox.Items.Count - 1);
                _projectSerializer.SaveToFile(_project);
            }
        }


        /// <summary>
        /// Форма помощи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Смена иконки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32;
            AddButton.BackColor = MOUSEENTER;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddButton.BackColor = CORRECT;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveButton.BackColor = DELETEMOUSEENTER;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveButton.BackColor = CORRECT;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32;
            EditButton.BackColor = MOUSEENTER;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditButton.BackColor = CORRECT;
        }


        /// <summary>
        /// Скрытие панели именинников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelNotiicationButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }
    }
}
