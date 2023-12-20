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

namespace kotyk
{
    public partial class ChooseGroupForm : Form
    {
        private Lecturer lecturer;
        private Course course;

        public ChooseGroupForm(Lecturer lecturer, Course course)
        {
            InitializeComponent();
            this.lecturer = lecturer;
            this.course = course;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
            this.LecturerLabel.Text = "Lecturer " + lecturer.getName() + " " + lecturer.getSurname();
            this.CourseLabel.Text = "Course " + course.getName();

            dbPrinter dbPrinter = new();
            List<Group> groups = dbPrinter.PrintGroupsByCourse(course);
            if (groups.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoGroupsForCourse(course);
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

        private void ChooseGroupButton_Click(object sender, EventArgs e)
        {
            Group selectedGroup = (Group)ChooseGroupBox.SelectedItem;

            AddGradeForm addGradeForm = new(lecturer, course, selectedGroup);
            if (addGradeForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(addGradeForm);
                addGradeForm.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ChooseCourseForm ChooseCourseForm = new(lecturer);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(ChooseCourseForm);
            ChooseCourseForm.Show();
        }
    }
}
