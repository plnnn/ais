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
    public partial class ViewCoursesForm : Form
    {
        private Administrator administrator;

        public ViewCoursesForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            panelForms.Location = new Point(0, 0);
            panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new dbPrinter();
            List<Course> courses = dbPrinter.PrintCourses();
            if (courses.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoCourses();
                return;
            }
            CoursesGrid.AutoGenerateColumns = true;
            CoursesGrid.DataSource = courses;
        }

        public bool Valid()
        {
            if (this.CoursesGrid.Rows.Count == 0) return false;
            return true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(viewForm);
            viewForm.Show();
        }
    }
}
