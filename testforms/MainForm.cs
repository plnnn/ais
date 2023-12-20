using bebra;
using kotyk;
using System;
using System.Windows.Forms;

namespace testforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdministratorButton_Click(object sender, EventArgs e)
        {
            AdministratorAuthorizationForm adminAuthForm = new();
            panelForms.Controls.Clear();
            panelForms.Controls.Add(adminAuthForm);
            adminAuthForm.Show();
        }

        private void LecturerButton_Click(object sender, EventArgs e)
        {
            LecturerAuthorizationForm lecturerAuthForm = new();
            panelForms.Controls.Clear();
            panelForms.Controls.Add(lecturerAuthForm);
            lecturerAuthForm.Show();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentAuthorizationForm studentAuthForm = new();
            panelForms.Controls.Clear();
            panelForms.Controls.Add(studentAuthForm);
            studentAuthForm.Show();
        }
    }
}
