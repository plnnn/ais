﻿using kotyk.Classes;
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
    public partial class DeleteGroupForm : Form
    {
        private Administrator administrator;

        public DeleteGroupForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);

            dbPrinter dbPrinter = new dbPrinter();
            List<Group> groups = dbPrinter.PrintGroups();
            if (groups.Count == 0)
            {
                Feedbacker errorHandler = new();
                errorHandler.NoGroups();
                return;
            }
            this.ChooseGroupBox.DataSource = groups;
            this.ChooseGroupBox.DisplayMember = "code";
            this.ChooseGroupBox.ValueMember = "ID";
        }

        public bool Valid()
        {
            if (this.ChooseGroupBox.Items.Count == 0) return false;
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
            Group selectedGroup = (Group)ChooseGroupBox.SelectedItem;

            administrator.DelGroup(selectedGroup);

            DeleteGroupForm deleteGroupForm = new(administrator);
            if (deleteGroupForm.Valid())
            {
                panelForms.Controls.Clear();
                panelForms.Controls.Add(deleteGroupForm);
                deleteGroupForm.Show();
            }
            else BackButton_Click(sender, e);
        }
    }
}
