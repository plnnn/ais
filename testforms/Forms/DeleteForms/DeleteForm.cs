using kotyk.Classes;
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
    public partial class DeleteForm : Form
    {
        private Administrator administrator;

        public DeleteForm(Administrator administrator)
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

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            DeleteStudentForm deleteStudentForm = new(administrator);
            if (deleteStudentForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(deleteStudentForm);
                deleteStudentForm.Show();
            }
        }

        private void DeleteLecturerButton_Click(object sender, EventArgs e)
        {
            DeleteLecturerForm deleteLecturerForm = new(administrator);
            if (deleteLecturerForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(deleteLecturerForm);
                deleteLecturerForm.Show();
            }
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new(administrator);
            if (deleteCourseForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(deleteCourseForm);
                deleteCourseForm.Show();
            }
        }

        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            DeleteGroupForm deleteGroupForm = new(administrator);
            if (deleteGroupForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(deleteGroupForm);
                deleteGroupForm.Show();
            }
        }
    }
}
