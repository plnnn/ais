using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bebra;
using Microsoft.VisualBasic.Devices;
using Org.BouncyCastle.Asn1.BC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kotyk
{
    public partial class AddStudentForm : Form
    {
        private Administrator administrator;

        public AddStudentForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new();
            List<Group> groups = dbPrinter.PrintGroups();
            if (groups.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoGroups();
                return;
            }

            this.ChooseGroupBox.DataSource = groups;
            this.ChooseGroupBox.DisplayMember = "code";
            this.ChooseGroupBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseGroupBox.Items.Count == 0) return false;
            return true;
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
            if (!validator.IsUsernameValid("students", username))
            {
                feedbacker.UsernameForTableIsTaken("students", username);
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

            Group group = (Group)ChooseGroupBox.SelectedItem;

            administrator.AddStudent(new("", username, surname, name, surname, group.ID));

            AddStudentForm addStudentForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addStudentForm);
            addStudentForm.Show();
        }
    }
}
