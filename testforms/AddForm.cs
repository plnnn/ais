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
using testforms;

namespace kotyk
{
    public partial class AddForm : Form
    {
        private Administrator administrator;

        public AddForm(Administrator administrator)
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

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new(administrator);
            if (addStudentForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(addStudentForm);
                addStudentForm.Show();
            }
        }

        private void AddLecturerButton_Click(object sender, EventArgs e)
        {
            AddLecturerForm addLecturerForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addLecturerForm);
            addLecturerForm.Show();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new(administrator);
            if (addCourseForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(addCourseForm);
                addCourseForm.Show();
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addGroupForm);
            addGroupForm.Show();
        }
    }
}
