namespace kotyk
{
    partial class ChooseGroupForm
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
            ChooseGroupBox = new ComboBox();
            ChooseGroupButton = new Button();
            panelForms = new Panel();
            BackButton = new Button();
            CourseLabel = new Label();
            LecturerLabel = new Label();
            GroupLabel = new Label();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // ChooseGroupBox
            // 
            ChooseGroupBox.FormattingEnabled = true;
            ChooseGroupBox.Location = new Point(267, 175);
            ChooseGroupBox.Name = "ChooseGroupBox";
            ChooseGroupBox.Size = new Size(121, 23);
            ChooseGroupBox.TabIndex = 0;
            ChooseGroupBox.Text = "Choose group";
            // 
            // ChooseGroupButton
            // 
            ChooseGroupButton.Location = new Point(394, 175);
            ChooseGroupButton.Name = "ChooseGroupButton";
            ChooseGroupButton.Size = new Size(75, 23);
            ChooseGroupButton.TabIndex = 1;
            ChooseGroupButton.Text = "OK";
            ChooseGroupButton.UseVisualStyleBackColor = true;
            ChooseGroupButton.Click += ChooseGroupButton_Click;
            // 
            // panelForms
            // 
            panelForms.Controls.Add(GroupLabel);
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(CourseLabel);
            panelForms.Controls.Add(LecturerLabel);
            panelForms.Controls.Add(ChooseGroupBox);
            panelForms.Controls.Add(ChooseGroupButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 3;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Location = new Point(12, 53);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(44, 15);
            CourseLabel.TabIndex = 3;
            CourseLabel.Text = "Course";
            // 
            // LecturerLabel
            // 
            LecturerLabel.AutoSize = true;
            LecturerLabel.Location = new Point(12, 38);
            LecturerLabel.Name = "LecturerLabel";
            LecturerLabel.Size = new Size(50, 15);
            LecturerLabel.TabIndex = 2;
            LecturerLabel.Text = "Lecturer";
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(267, 157);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(40, 15);
            GroupLabel.TabIndex = 5;
            GroupLabel.Text = "Group";
            // 
            // ChooseGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "ChooseGroupForm";
            Text = "ChooseGroupForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ChooseGroupBox;
        private Button ChooseGroupButton;
        private Panel panelForms;
        private Label CourseLabel;
        private Label LecturerLabel;
        private Button BackButton;
        private Label GroupLabel;
    }
}