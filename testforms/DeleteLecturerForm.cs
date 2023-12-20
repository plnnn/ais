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
    public partial class DeleteLecturerForm : Form
    {
        private Administrator administrator;

        public DeleteLecturerForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new dbPrinter();
            List<Lecturer> lecturers = dbPrinter.PrintLecturers();
            if (lecturers.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoLecturers();
                return;
            }
            this.ChooseLecturerBox.DataSource = lecturers;
            this.ChooseLecturerBox.DisplayMember = "surname";
            this.ChooseLecturerBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseLecturerBox.Items.Count == 0) return false;
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
            Lecturer selectedLecturer = (Lecturer)ChooseLecturerBox.SelectedItem;

            administrator.DelLecturer(selectedLecturer);

            DeleteLecturerForm deleteLecturerForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(deleteLecturerForm);
            deleteLecturerForm.Show();
        }
    }
}
