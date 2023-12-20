using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kotyk.Classes;

namespace kotyk
{
    public partial class DeleteStudentForm : Form
    {
        private Administrator administrator;

        public DeleteStudentForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new dbPrinter();
            List<Student> students = dbPrinter.PrintStudents();
            if (students.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoStudents();
                return;
            }
            this.ChooseStudentBox.DataSource = students;
            this.ChooseStudentBox.DisplayMember = "surname";
            this.ChooseStudentBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseStudentBox.Items.Count == 0) return false;
            return true;
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(deleteForm);
            deleteForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)ChooseStudentBox.SelectedItem;

            administrator.DelStudent(selectedStudent);

            DeleteStudentForm deleteStudentForm = new(administrator);
            if (deleteStudentForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(deleteStudentForm);
                deleteStudentForm.Show();
            }
            else BackButton_Click(sender, e);
        }
    }
}
