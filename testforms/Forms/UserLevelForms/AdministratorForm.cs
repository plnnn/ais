using kotyk;
using kotyk.Classes.dbObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testforms
{
    public partial class AdministratorForm : Form
    {
        private Administrator administrator;

        public AdministratorForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.HelloLabel.Text = "Hello, " + administrator.getName() + " " + administrator.getSurname();
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addForm);
            addForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(deleteForm);
            deleteForm.Show();
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            AssignForm assignForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(assignForm);
            assignForm.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(viewForm);
            viewForm.Show();
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
