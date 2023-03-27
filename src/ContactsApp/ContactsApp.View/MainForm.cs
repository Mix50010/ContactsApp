using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            deleteContactButton.Image = Properties.Resources.remove_contact_32x32;
            deleteContactButton.BackColor = System.Drawing.Color.FromArgb(0xFF, 0xF5, 0xF5, 0xFF);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            deleteContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            deleteContactButton.BackColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactForm form = new ContactForm();
            form.Show();
        }

        private void editContactButton_MouseEnter(object sender, EventArgs e)
        {
            editContactButton.Image = Properties.Resources.edit_contact_32x32;
        }

        private void editContactButton_MouseLeave(object sender, EventArgs e)
        {
            editContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
        }

        private void createButtonContact_MouseEnter(object sender, EventArgs e)
        {
            createButtonContact.Image = Properties.Resources.add_contact_32x32;
        }

        private void createButtonContact_MouseLeave(object sender, EventArgs e)
        {
            createButtonContact.Image = Properties.Resources.add_contact_32x32_gray;
        }

        
    }
}
