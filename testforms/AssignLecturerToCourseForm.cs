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

namespace kotyk
{
    public partial class AssignLecturerToCourseForm : Form
    {
        private Administrator administrator;

        public AssignLecturerToCourseForm(Administrator administrator)
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
            Feedbacker errorHandler = new();
            if (lecturers.Count == 0)
            {
                errorHandler.NoLecturers();
                return;
            }
            this.ChooseLecturerBox.DataSource = lecturers;
            this.ChooseLecturerBox.DisplayMember = "surname";
            this.ChooseLecturerBox.ValueMember = "ID";

            List<Course> courses = dbPrinter.PrintCourses();
            if (courses.Count == 0)
            {
                errorHandler.NoCourses();
                return;
            }
            this.ChooseCourseBox.DataSource = courses;
            this.ChooseCourseBox.DisplayMember = "name";
            this.ChooseCourseBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseLecturerBox.Items.Count == 0) return false;
            if (this.ChooseCourseBox.Items.Count == 0) return false;
            return true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AssignForm assignForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(assignForm);
            assignForm.Show();
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = (Lecturer)ChooseLecturerBox.SelectedItem;

            Course course = (Course)ChooseCourseBox.SelectedItem;

            administrator.AssignLecturerToCourse(lecturer, course);

            AssignLecturerToCourseForm assignLecturerToCourseForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(assignLecturerToCourseForm);
            assignLecturerToCourseForm.Show();
        }
    }
}
