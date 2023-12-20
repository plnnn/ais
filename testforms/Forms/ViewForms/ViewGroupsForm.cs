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

namespace kotyk
{
    public partial class ViewGroupsForm : Form
    {
        private Administrator administrator;

        public ViewGroupsForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            panelForms.Location = new Point(0, 0);
            panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new dbPrinter();
            List<Group> groups = dbPrinter.PrintGroups();
            if (groups.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoGroups();
                return;
            }
            GroupsGrid.AutoGenerateColumns = true;
            GroupsGrid.DataSource = groups;
        }

        public bool Valid()
        {
            if (this.GroupsGrid.Rows.Count == 0) return false;
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
