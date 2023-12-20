namespace kotyk
{
    partial class AssignForm
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
            BackButton = new Button();
            AssignCourseToGroupButton = new Button();
            AssignGroupToStudentButton = new Button();
            AssignLabel = new Label();
            AssignLecturerToCourseButton = new Button();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(AssignCourseToGroupButton);
            panelForms.Controls.Add(AssignGroupToStudentButton);
            panelForms.Controls.Add(AssignLabel);
            panelForms.Controls.Add(AssignLecturerToCourseButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 6;
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
            // AssignCourseToGroupButton
            // 
            AssignCourseToGroupButton.Location = new Point(58, 181);
            AssignCourseToGroupButton.Name = "AssignCourseToGroupButton";
            AssignCourseToGroupButton.Size = new Size(126, 23);
            AssignCourseToGroupButton.TabIndex = 4;
            AssignCourseToGroupButton.Text = "Course to group";
            AssignCourseToGroupButton.UseVisualStyleBackColor = true;
            AssignCourseToGroupButton.Click += AssignCourseToGroupButton_Click;
            // 
            // AssignGroupToStudentButton
            // 
            AssignGroupToStudentButton.Location = new Point(58, 152);
            AssignGroupToStudentButton.Name = "AssignGroupToStudentButton";
            AssignGroupToStudentButton.Size = new Size(126, 23);
            AssignGroupToStudentButton.TabIndex = 3;
            AssignGroupToStudentButton.Text = "Group to student";
            AssignGroupToStudentButton.UseVisualStyleBackColor = true;
            AssignGroupToStudentButton.Click += AssignGroupToStudentButton_Click;
            // 
            // AssignLabel
            // 
            AssignLabel.AutoSize = true;
            AssignLabel.Location = new Point(58, 105);
            AssignLabel.Name = "AssignLabel";
            AssignLabel.Size = new Size(45, 15);
            AssignLabel.TabIndex = 2;
            AssignLabel.Text = "Assign:";
            // 
            // AssignLecturerToCourseButton
            // 
            AssignLecturerToCourseButton.Location = new Point(58, 123);
            AssignLecturerToCourseButton.Name = "AssignLecturerToCourseButton";
            AssignLecturerToCourseButton.Size = new Size(126, 23);
            AssignLecturerToCourseButton.TabIndex = 1;
            AssignLecturerToCourseButton.Text = "Lecturer to course";
            AssignLecturerToCourseButton.UseVisualStyleBackColor = true;
            AssignLecturerToCourseButton.Click += AssignLecturerToCourseButton_Click;
            // 
            // AssignForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AssignForm";
            Text = "AssignForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private Button BackButton;
        private Button AssignCourseToGroupButton;
        private Button AssignGroupToStudentButton;
        private Label AssignLabel;
        private Button AssignLecturerToCourseButton;
    }
}