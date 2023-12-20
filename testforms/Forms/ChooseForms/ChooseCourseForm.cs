using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kotyk.Classes.dbObjects;
using kotyk.Classes.FunctionClasses;
using Microsoft.VisualBasic.Devices;

namespace kotyk
{
    public partial class ChooseCourseForm : Form
    {
        Lecturer lecturer;

        public ChooseCourseForm(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
            this.LecturerLabel.Text = "Lecturer " + lecturer.getName() + " " + lecturer.getSurname();

            dbPrinter dbPrinter = new dbPrinter();
            List<Course> courses = dbPrinter.PrintLecturersCourses(lecturer);
            if (courses.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoCoursesFoundForLecturer();
                return;
            }
            this.ChooseCourseBox.DataSource = courses;
            this.ChooseCourseBox.DisplayMember = "name";
            this.ChooseCourseBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseCourseBox.Items.Count == 0) return false;
            return true;
        }

        private void ChooseCourseButton_Click(object sender, EventArgs e)
        {
            Course selectedCourse = (Course)ChooseCourseBox.SelectedItem;

            ChooseGroupForm chooseGroupForm = new(lecturer, selectedCourse);
            if (chooseGroupForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(chooseGroupForm);
                chooseGroupForm.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LecturerForm lecturerForm = new(lecturer);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(lecturerForm);
            lecturerForm.Show();
        }
    }
}
