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
    public partial class StudentForm : Form
    {
        private Student student;

        public StudentForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.HelloLabel.Text = "Hello, " + student.getName() + " " + student.getSurname();
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void ViewGradesButton_Click(object sender, EventArgs e)
        {
            ViewGradesForm viewGradesForm = new(student);
            if (viewGradesForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(viewGradesForm);
                viewGradesForm.Show();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.TopLevel = false;
            mainForm.FormBorderStyle = FormBorderStyle.None;
            mainForm.Dock = DockStyle.Fill;
            panelForms.Controls.Clear();
            panelForms.Controls.Add(mainForm);
            mainForm.Show();
        }
    }
}
