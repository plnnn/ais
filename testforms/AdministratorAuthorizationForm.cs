using bebra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testforms;

namespace kotyk
{
    public partial class AdministratorAuthorizationForm : Form
    {
        public AdministratorAuthorizationForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            Authorizer authorizer = new();
            Administrator administrator = authorizer.AdministratorAuthorization(username, password);
            if (administrator == null) return;

            AdministratorForm adminForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(adminForm);
            adminForm.Show();
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "username")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "username";
                UsernameTextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "password";
                PasswordTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
