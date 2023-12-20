namespace kotyk
{
    partial class DeleteForm
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
            DeleteGroupButton = new Button();
            DeleteCourseButton = new Button();
            DeleteLecturerButton = new Button();
            DeleteLabel = new Label();
            DeleteStudentButton = new Button();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(DeleteGroupButton);
            panelForms.Controls.Add(DeleteCourseButton);
            panelForms.Controls.Add(DeleteLecturerButton);
            panelForms.Controls.Add(DeleteLabel);
            panelForms.Controls.Add(DeleteStudentButton);
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
            // DeleteGroupButton
            // 
            DeleteGroupButton.Location = new Point(58, 210);
            DeleteGroupButton.Name = "DeleteGroupButton";
            DeleteGroupButton.Size = new Size(98, 23);
            DeleteGroupButton.TabIndex = 5;
            DeleteGroupButton.Text = "Group";
            DeleteGroupButton.UseVisualStyleBackColor = true;
            DeleteGroupButton.Click += DeleteGroupButton_Click;
            // 
            // DeleteCourseButton
            // 
            DeleteCourseButton.Location = new Point(58, 181);
            DeleteCourseButton.Name = "DeleteCourseButton";
            DeleteCourseButton.Size = new Size(98, 23);
            DeleteCourseButton.TabIndex = 4;
            DeleteCourseButton.Text = "Course";
            DeleteCourseButton.UseVisualStyleBackColor = true;
            DeleteCourseButton.Click += DeleteCourseButton_Click;
            // 
            // DeleteLecturerButton
            // 
            DeleteLecturerButton.Location = new Point(58, 152);
            DeleteLecturerButton.Name = "DeleteLecturerButton";
            DeleteLecturerButton.Size = new Size(98, 23);
            DeleteLecturerButton.TabIndex = 3;
            DeleteLecturerButton.Text = "Lecturer";
            DeleteLecturerButton.UseVisualStyleBackColor = true;
            DeleteLecturerButton.Click += DeleteLecturerButton_Click;
            // 
            // DeleteLabel
            // 
            DeleteLabel.AutoSize = true;
            DeleteLabel.Location = new Point(58, 105);
            DeleteLabel.Name = "DeleteLabel";
            DeleteLabel.Size = new Size(43, 15);
            DeleteLabel.TabIndex = 2;
            DeleteLabel.Text = "Delete:";
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new Point(58, 123);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(98, 23);
            DeleteStudentButton.TabIndex = 1;
            DeleteStudentButton.Text = "Student";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "DeleteForm";
            Text = "DeleteForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private Button BackButton;
        private Button DeleteGroupButton;
        private Button DeleteCourseButton;
        private Button DeleteLecturerButton;
        private Label DeleteLabel;
        private Button DeleteStudentButton;
    }
}