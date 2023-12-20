namespace kotyk
{
    partial class AddLecturerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelForms = new Panel();
            AddButton = new Button();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            BackButton = new Button();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(AddButton);
            panelForms.Controls.Add(SurnameTextBox);
            panelForms.Controls.Add(NameTextBox);
            panelForms.Controls.Add(UsernameTextBox);
            panelForms.Controls.Add(BackButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(333, 226);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 23);
            AddButton.TabIndex = 11;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.ForeColor = SystemColors.GrayText;
            SurnameTextBox.Location = new Point(333, 197);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(100, 23);
            SurnameTextBox.TabIndex = 9;
            SurnameTextBox.Text = "surname";
            SurnameTextBox.Enter += SurnameTextBox_Enter;
            SurnameTextBox.Leave += SurnameTextBox_Leave;
            // 
            // NameTextBox
            // 
            NameTextBox.ForeColor = SystemColors.GrayText;
            NameTextBox.Location = new Point(333, 168);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 8;
            NameTextBox.Text = "name";
            NameTextBox.Enter += NameTextBox_Enter;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.ForeColor = SystemColors.GrayText;
            UsernameTextBox.Location = new Point(333, 139);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(100, 23);
            UsernameTextBox.TabIndex = 7;
            UsernameTextBox.Text = "username";
            UsernameTextBox.Enter += UsernameTextBox_Enter;
            UsernameTextBox.Leave += UsernameTextBox_Leave;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddLecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AddLecturerForm";
            Text = "AddLecturerForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private Button AddButton;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private TextBox UsernameTextBox;
        private Button BackButton;
    }
}