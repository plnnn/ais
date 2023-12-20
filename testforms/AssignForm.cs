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
    public partial class AssignForm : Form
    {
        private Administrator administrator;

        public AssignForm(Administrator administrator)
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
            AdministratorForm administratorForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(administratorForm);
            administratorForm.Show();
        }

        private void AssignLecturerToCourseButton_Click(object sender, EventArgs e)
        {
            AssignLecturerToCourseForm assignLecturerToCourseForm = new(administrator);
            if (assignLecturerToCourseForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(assignLecturerToCourseForm);
                assignLecturerToCourseForm.Show();
            }
        }

        private void AssignGroupToStudentButton_Click(object sender, EventArgs e)
        {
            AssignGroupToStudentForm assignGroupToStudentForm = new(administrator);
            if (assignGroupToStudentForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(assignGroupToStudentForm);
                assignGroupToStudentForm.Show();
            }
        }

        private void AssignCourseToGroupButton_Click(object sender, EventArgs e)
        {
            AssignCourseToGroupForm assignCourseToGroupForm = new(administrator);
            if (assignCourseToGroupForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(assignCourseToGroupForm);
                assignCourseToGroupForm.Show();
            }
        }
    }
}
