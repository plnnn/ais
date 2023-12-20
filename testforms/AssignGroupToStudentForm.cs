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
    public partial class AssignGroupToStudentForm : Form
    {
        private Administrator administrator;

        public AssignGroupToStudentForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new();
            List<Student> students = dbPrinter.PrintStudents();
            Feedbacker errorHandler = new();
            if (students.Count == 0)
            {
                errorHandler.NoStudents();
                return;
            }
            this.ChooseStudentBox.DataSource = students;
            this.ChooseStudentBox.DisplayMember = "surname";
            this.ChooseStudentBox.ValueMember = "ID";

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
            if (this.ChooseStudentBox.Items.Count == 0) return false;
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
            Student student = (Student)ChooseStudentBox.SelectedItem;

            Group group = (Group)ChooseGroupBox.SelectedItem;

            administrator.AssignGroupToStudent(group, student);

            AssignGroupToStudentForm assignGroupToStudentForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(assignGroupToStudentForm);
            assignGroupToStudentForm.Show();
        }
    }
}
