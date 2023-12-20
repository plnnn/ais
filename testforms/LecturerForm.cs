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
    public partial class LecturerForm : Form
    {
        private Lecturer lecturer;

        public LecturerForm(Lecturer lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.HelloLabel.Text = "Hello, " + lecturer.getName() + " " + lecturer.getSurname();
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void ManageGradesButton_Click(object sender, EventArgs e)
        {
            ChooseCourseForm chooseCourseForm = new(lecturer);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(chooseCourseForm);
            chooseCourseForm.Show();
        }
    }
}
