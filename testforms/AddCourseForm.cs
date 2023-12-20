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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kotyk
{
    public partial class AddCourseForm : Form
    {
        private Administrator administrator;

        public AddCourseForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new();
            List<Lecturer> lecturers = dbPrinter.PrintLecturers();
            if (lecturers.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoLecturers();
            }

            this.ChooseLecturerBox.DataSource = lecturers;
            this.ChooseLecturerBox.DisplayMember = "surname";
            this.ChooseLecturerBox.ValueMember = "ID";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addForm);
            addForm.Show();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;

            Feedbacker feedbacker = new Feedbacker();
            if (NameTextBox.ForeColor == Color.Gray)
            {
                feedbacker.EnterName();
                return;
            }

            Validator validator = new Validator();
            if (!validator.IsCourseNameValid(name))
            {
                feedbacker.CourseNameIsTaken(name);
                return;
            }

            Lecturer lecturer = (Lecturer)ChooseLecturerBox.SelectedItem;

            administrator.AddCourse(new("", name, lecturer.ID));

            AddCourseForm addCourseForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addCourseForm);
            addCourseForm.Show();
        }
    }
}
