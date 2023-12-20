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
    public partial class ViewForm : Form
    {
        private Administrator administrator;

        public ViewForm(Administrator administrator)
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

        private void ViewStudentsButton_Click(object sender, EventArgs e)
        {
            ViewStudentsForm viewStudentsForm = new(administrator);
            if (viewStudentsForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(viewStudentsForm);
                viewStudentsForm.Show();
            }
        }

        private void ViewLecturersButton_Click(object sender, EventArgs e)
        {
            ViewLecturersForm viewLecturersForm = new(administrator);
            if (viewLecturersForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(viewLecturersForm);
                viewLecturersForm.Show();
            }
        }

        private void ViewCoursesButton_Click(object sender, EventArgs e)
        {
            ViewCoursesForm viewCoursesForm = new(administrator);
            if (viewCoursesForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(viewCoursesForm);
                viewCoursesForm.Show();
            }
        }

        private void ViewGroupsButton_Click(object sender, EventArgs e)
        {
            ViewGroupsForm viewGroupsForm = new(administrator);
            if (viewGroupsForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(viewGroupsForm);
                viewGroupsForm.Show();
            }
        }
    }
}
