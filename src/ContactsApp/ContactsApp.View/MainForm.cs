using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary> 
        /// Проект. 
        /// </summary>
        private Project _project = new Project();

        private void UpdateListBox()
        {
            _project.Contacts.Sort();
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _project.Contacts)
                ContactsListBox.Items.Add(contact.FullName);
        }
        private void AddContact()
        {
            Contact contact = new Contact(ObjectFactory.GetFullName(),
                ObjectFactory.GetPhoneNumber(), ObjectFactory.GetEmail(),
                ObjectFactory.GetDateOfBirth(), ObjectFactory.GetVkID());
            _project.Contacts.Add(contact);
            
        }
        private void RemoveContact(int index)
        {
            if (index == -1)
                return; 
            if (MessageBox.Show("Вы действительно хотите удалить " + 
                _project.Contacts[index].FullName + "?") == DialogResult.OK)
                _project.Contacts.RemoveAt(index);
        }

        private void UpdateSelectedContact(int index)
        {
            FullNameTextbox.Text = _project.Contacts[index].FullName;
            EmailTextBox.Text = _project.Contacts[index].Email;
            PhoneNumberTextBox.Text = _project.Contacts[index].PhoneNumber;
            DateOfBirthTextBox.Text = _project.Contacts[index].DateOfBirth.ToLongDateString();
            VKTextBox.Text = _project.Contacts[index].VkID;
        }

        private void ClearSelectedContact()
        {
            FullNameTextbox.Clear();
            EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
            DateOfBirthTextBox.Clear();
            VKTextBox.Clear();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32;
            AddButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddButton.BackColor = Color.White;
        }


        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAF5F5");
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveButton.BackColor = Color.White;
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32;
            EditButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditButton.BackColor = Color.White;
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            //var form = new ContactForm();
            AddContact();
            UpdateListBox();
            //form.ShowDialog();
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1 || ContactsListBox.Items.Count == 0)
                ClearSelectedContact();
            else
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }
    }
}
