using kotyk.Classes.dbObjects;
using kotyk.Classes.FunctionClasses;
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
    public partial class AddGradeForm : Form
    {
        private Lecturer lecturer;
        private Course course;
        private Group group;

        public AddGradeForm(Lecturer lecturer, Course course, Group group)
        {
            InitializeComponent();
            this.lecturer = lecturer;
            this.course = course;
            this.group = group;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            panelForms.Location = new Point(0, 0);
            panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new();
            DataTable grades = dbPrinter.PrintGradesByCourseAndGroup(course, group);
            if (grades.Rows.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoGradesForCourseAndGroup(course, group);
                return;
            }
            GradesGrid.DataSource = grades;
            GradesGrid.ReadOnly = false;
            GradesGrid.Columns[0].ReadOnly = true;
            GradesGrid.Columns[1].ReadOnly = true;
            GradesGrid.Columns[2].ReadOnly = true;
            GradesGrid.Columns[3].ReadOnly = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ChooseGroupForm ChooseGroupForm = new(lecturer, course);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(ChooseGroupForm);
            ChooseGroupForm.Show();
        }

        public bool Valid()
        {
            if (this.GradesGrid.Rows.Count == 0) return false;
            return true;
        }

        private void GradesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newGrade = GradesGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
            string studentID = GradesGrid["ID", e.RowIndex].Value.ToString();

            lecturer.AddGrade(new(studentID, course.ID, newGrade));
        }

        private void GradesGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (GradesGrid.Columns[e.ColumnIndex].Name == "Grade")
            {
                Feedbacker feedbacker = new Feedbacker();
                if (e.FormattedValue.ToString() == "")
                {
                    e.Cancel = true;
                    feedbacker.GradeValidation();
                }
                else if (!int.TryParse(e.FormattedValue.ToString(), out int newValue))
                {
                    e.Cancel = true;
                    feedbacker.GradeValidation();
                }
                else if (newValue < 1 || newValue > 10)
                {
                    e.Cancel = true;
                    feedbacker.GradeValidation();
                }
            }
        }
    }
}
