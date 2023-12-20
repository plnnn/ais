﻿using bebra;
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
    public partial class ViewGradesForm : Form
    {
        private Student student;

        public ViewGradesForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            panelForms.Location = new Point(0, 0);
            panelForms.Size = new Size(800, 450);

            DataTable grades = student.ViewGrades();
            if (grades == null)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoCoursesFoundForStudent();
            }
            GradesGrid.DataSource = grades;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new(student);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(studentForm);
            studentForm.Show();
        }
    }
}
