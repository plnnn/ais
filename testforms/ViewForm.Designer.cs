namespace kotyk
{
    partial class ViewForm
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
            ViewGroupsButton = new Button();
            ViewCoursesButton = new Button();
            ViewLecturersButton = new Button();
            ViewLabel = new Label();
            ViewStudentsButton = new Button();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(ViewGroupsButton);
            panelForms.Controls.Add(ViewCoursesButton);
            panelForms.Controls.Add(ViewLecturersButton);
            panelForms.Controls.Add(ViewLabel);
            panelForms.Controls.Add(ViewStudentsButton);
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
            // ViewGroupsButton
            // 
            ViewGroupsButton.Location = new Point(58, 210);
            ViewGroupsButton.Name = "ViewGroupsButton";
            ViewGroupsButton.Size = new Size(98, 23);
            ViewGroupsButton.TabIndex = 5;
            ViewGroupsButton.Text = "Groups";
            ViewGroupsButton.UseVisualStyleBackColor = true;
            ViewGroupsButton.Click += ViewGroupsButton_Click;
            // 
            // ViewCoursesButton
            // 
            ViewCoursesButton.Location = new Point(58, 181);
            ViewCoursesButton.Name = "ViewCoursesButton";
            ViewCoursesButton.Size = new Size(98, 23);
            ViewCoursesButton.TabIndex = 4;
            ViewCoursesButton.Text = "Courses";
            ViewCoursesButton.UseVisualStyleBackColor = true;
            ViewCoursesButton.Click += ViewCoursesButton_Click;
            // 
            // ViewLecturersButton
            // 
            ViewLecturersButton.Location = new Point(58, 152);
            ViewLecturersButton.Name = "ViewLecturersButton";
            ViewLecturersButton.Size = new Size(98, 23);
            ViewLecturersButton.TabIndex = 3;
            ViewLecturersButton.Text = "Lecturers";
            ViewLecturersButton.UseVisualStyleBackColor = true;
            ViewLecturersButton.Click += ViewLecturersButton_Click;
            // 
            // ViewLabel
            // 
            ViewLabel.AutoSize = true;
            ViewLabel.Location = new Point(58, 105);
            ViewLabel.Name = "ViewLabel";
            ViewLabel.Size = new Size(35, 15);
            ViewLabel.TabIndex = 2;
            ViewLabel.Text = "View:";
            // 
            // ViewStudentsButton
            // 
            ViewStudentsButton.Location = new Point(58, 123);
            ViewStudentsButton.Name = "ViewStudentsButton";
            ViewStudentsButton.Size = new Size(98, 23);
            ViewStudentsButton.TabIndex = 1;
            ViewStudentsButton.Text = "Students";
            ViewStudentsButton.UseVisualStyleBackColor = true;
            ViewStudentsButton.Click += ViewStudentsButton_Click;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "ViewForm";
            Text = "ViewForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private Button BackButton;
        private Button ViewGroupsButton;
        private Button ViewCoursesButton;
        private Button ViewLecturersButton;
        private Label ViewLabel;
        private Button ViewStudentsButton;
    }
}