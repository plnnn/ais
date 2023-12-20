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
    public partial class AssignCourseToGroupForm : Form
    {
        private Administrator administrator;

        public AssignCourseToGroupForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new();
            List<Course> courses = dbPrinter.PrintCourses();
            Feedbacker errorHandler = new();
            if (courses.Count == 0)
            {
                errorHandler.NoCourses();
                return;
            }
            this.ChooseCourseBox.DataSource = courses;
            this.ChooseCourseBox.DisplayMember = "name";
            this.ChooseCourseBox.ValueMember = "ID";

            List<Group> groups = dbPrinter.PrintGroups();
            if (groups.Count == 0)
            {
                errorHandler.NoGroups();
                return;
            }
            this.ChooseGroupBox.DataSource = groups;
            this.ChooseGroupBox.DisplayMember = "code";
            this.ChooseGroupBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseCourseBox.Items.Count == 0) return false;
            if (this.ChooseGroupBox.Items.Count == 0) return false;
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
            Course course = (Course)ChooseCourseBox.SelectedItem;

            Group group = (Group)ChooseGroupBox.SelectedItem;

            administrator.AssignCourseToGroup(course, group);

            AssignCourseToGroupForm assignCourseToGroupForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(assignCourseToGroupForm);
            assignCourseToGroupForm.Show();
        }
    }
}
