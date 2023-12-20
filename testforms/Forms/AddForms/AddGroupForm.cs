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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kotyk
{
    public partial class AddGroupForm : Form
    {
        private Administrator administrator;

        public AddGroupForm(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.panelForms.Location = new Point(0, 0);
            this.panelForms.Size = new Size(800, 450);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addForm);
            addForm.Show();
        }

        private void CodeTextBox_Enter(object sender, EventArgs e)
        {
            if (CodeTextBox.Text == "code")
            {
                CodeTextBox.Text = "";
                CodeTextBox.ForeColor = Color.Black;
            }
        }

        private void CodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodeTextBox.Text))
            {
                CodeTextBox.Text = "code";
                CodeTextBox.ForeColor = Color.Gray;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string code = CodeTextBox.Text;
            Feedbacker feedbacker = new Feedbacker();
            if (CodeTextBox.ForeColor == Color.Gray)
            {
                feedbacker.EnterCode();
                return;
            }

            Validator validator = new Validator();
            if (!validator.IsGroupCodeValid(code))
            {
                feedbacker.GroupCodeIsTaken(code);
                return;
            }

            administrator.AddGroup(new Group("", code));

            AddGroupForm addGroupForm = new(administrator);
            panelForms.Controls.Clear();
            panelForms.Controls.Add(addGroupForm);
            addGroupForm.Show();
        }
    }
}
