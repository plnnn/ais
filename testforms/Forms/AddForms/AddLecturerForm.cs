using kotyk.Classes.dbObjects;
using kotyk.Classes.FunctionClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kotyk
{
    public partial class AddLecturerForm : Form
    {
        private Administrator administrator;

        public AddLecturerForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addForm);
            addForm.Show();
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

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "name")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                NameTextBox.Text = "name";
                NameTextBox.ForeColor = Color.Gray;
            }
        }

        private void SurnameTextBox_Enter(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text == "surname")
            {
                SurnameTextBox.Text = "";
                SurnameTextBox.ForeColor = Color.Black;
            }
        }

        private void SurnameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SurnameTextBox.Text))
            {
                SurnameTextBox.Text = "surname";
                SurnameTextBox.ForeColor = Color.Gray;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;

            Feedbacker feedbacker = new Feedbacker();
            if (UsernameTextBox.ForeColor == Color.Gray)
            {
                feedbacker.EnterUsername();
                return;
            }

            Validator validator = new Validator();
            if (!validator.IsUsernameValid("lecturers", username))
            {
                feedbacker.UsernameForTableIsTaken("lecturers", username);
                return;
            }

            string name = NameTextBox.Text;
            if (NameTextBox.ForeColor == Color.Gray)
            {
                feedbacker.EnterName();
                return;
            }

            string surname = SurnameTextBox.Text;
            if (SurnameTextBox.ForeColor == Color.Gray)
            {
                feedbacker.EnterSurname();
                return;
            }

            administrator.AddLecturer(new("", username, surname, name, surname));

            AddLecturerForm addLecturerForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addLecturerForm);
            addLecturerForm.Show();
        }
    }
}
