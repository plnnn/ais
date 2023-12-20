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
    public partial class ViewStudentsForm : Form
    {
        private Administrator administrator;

        public ViewStudentsForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            panelForms.Location = new Point(0, 0);
            panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new dbPrinter();
            List<Student> students = dbPrinter.PrintStudents();
            if (students.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoStudents();
                return;
            }
            StudentsGrid.AutoGenerateColumns = true;
            StudentsGrid.DataSource = students;
        }

        public bool Valid()
        {
            if (this.StudentsGrid.Rows.Count == 0) return false;
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
