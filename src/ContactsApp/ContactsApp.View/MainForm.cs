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
            button3.Text = "Test";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = "";
        }
    }
}
