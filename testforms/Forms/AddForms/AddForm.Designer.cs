namespace kotyk
{
    partial class AddForm
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
            AddStudentButton = new Button();
            panelForms = new Panel();
            BackButton = new Button();
            AddGroupButton = new Button();
            AddCourseButton = new Button();
            AddLecturerButton = new Button();
            AddLabel = new Label();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(58, 123);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(98, 23);
            AddStudentButton.TabIndex = 1;
            AddStudentButton.Text = "Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // panelForms
            // 
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(AddGroupButton);
            panelForms.Controls.Add(AddCourseButton);
            panelForms.Controls.Add(AddLecturerButton);
            panelForms.Controls.Add(AddLabel);
            panelForms.Controls.Add(AddStudentButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 5;
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
            // AddGroupButton
            // 
            AddGroupButton.Location = new Point(58, 210);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(98, 23);
            AddGroupButton.TabIndex = 5;
            AddGroupButton.Text = "Group";
            AddGroupButton.UseVisualStyleBackColor = true;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // AddCourseButton
            // 
            AddCourseButton.Location = new Point(58, 181);
            AddCourseButton.Name = "AddCourseButton";
            AddCourseButton.Size = new Size(98, 23);
            AddCourseButton.TabIndex = 4;
            AddCourseButton.Text = "Course";
            AddCourseButton.UseVisualStyleBackColor = true;
            AddCourseButton.Click += AddCourseButton_Click;
            // 
            // AddLecturerButton
            // 
            AddLecturerButton.Location = new Point(58, 152);
            AddLecturerButton.Name = "AddLecturerButton";
            AddLecturerButton.Size = new Size(98, 23);
            AddLecturerButton.TabIndex = 3;
            AddLecturerButton.Text = "Lecturer";
            AddLecturerButton.UseVisualStyleBackColor = true;
            AddLecturerButton.Click += AddLecturerButton_Click;
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Location = new Point(58, 105);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(32, 15);
            AddLabel.TabIndex = 2;
            AddLabel.Text = "Add:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AddForm";
            Text = "AddForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddStudentButton;
        private Panel panelForms;
        private Button AddGroupButton;
        private Button AddCourseButton;
        private Button AddLecturerButton;
        private Label AddLabel;
        private Button BackButton;
    }
}