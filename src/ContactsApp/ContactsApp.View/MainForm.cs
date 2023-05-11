using System;
using System.Drawing;
using System.Reflection;
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
        /// Проект. 
        /// </summary>
        private Project _project = new Project();

        /// <summary> 
        /// Обновляет ЛистБокс с контактами. 
        /// </summary> 
        private void UpdateListBox()
        {
            _project.Contacts.Sort();
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _project.Contacts)
                ContactsListBox.Items.Add(contact.FullName);

        }

        /// <summary> 
        /// Добавляет контакт в проект. 
        /// </summary> 
        private void AddContact()
        {
            Contact contact = new Contact(ObjectFactory.GetFullName(),
                ObjectFactory.GetPhoneNumber(), ObjectFactory.GetEmail(),
                ObjectFactory.GetDateOfBirth(), ObjectFactory.GetVkID());
            _project.Contacts.Add(contact);
            
        }

        /// <summary> 
        /// Удаляет контакт из проекта. 
        /// </summary> 
        private void RemoveContact(int index)
        {
            if (index == -1)
                return; 
            if (MessageBox.Show("Вы действительно хотите удалить " + 
                _project.Contacts[index].FullName + "?") == DialogResult.OK)
                _project.Contacts.RemoveAt(index);
        }
        /// <summary> 
        /// Обновляет информацию о текущем выбранном контакте. 
        /// </summary> 
        private void UpdateSelectedContact(int index)
        {
            FullNameTextbox.Text = _project.Contacts[index].FullName;
            EmailTextBox.Text = _project.Contacts[index].Email;
            PhoneNumberTextBox.Text = _project.Contacts[index].PhoneNumber;
            DateOfBirthTextBox.Text = _project.Contacts[index].DateOfBirth.ToLongDateString();
            VKTextBox.Text = _project.Contacts[index].VkID;
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
        }

        /// <summary>
        /// Открывает форму редактирования или создания.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
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
            AddButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddButton.BackColor = Color.White;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveButton.BackColor = Color.White;
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32;
            EditButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Смена иконки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditButton.BackColor = Color.White;
        }

        /// <summary>
        /// Добавление контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            //var form = new ContactForm();
            AddContact();
            UpdateListBox();
            //form.ShowDialog();
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
        /// Скрытие панели именинников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// Вызов изменения контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Обновление информации о контакте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
                ClearSelectedContact();
            else
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }
    }
}
