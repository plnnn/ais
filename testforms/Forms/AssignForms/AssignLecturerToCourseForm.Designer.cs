namespace kotyk
{
    partial class AssignLecturerToCourseForm
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
            ChooseCourseBox = new ComboBox();
            AssignButton = new Button();
            ChooseLecturerBox = new ComboBox();
            BackButton = new Button();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(ChooseCourseBox);
            panelForms.Controls.Add(AssignButton);
            panelForms.Controls.Add(ChooseLecturerBox);
            panelForms.Controls.Add(BackButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 8;
            // 
            // ChooseCourseBox
            // 
            ChooseCourseBox.FormattingEnabled = true;
            ChooseCourseBox.Location = new Point(333, 168);
            ChooseCourseBox.Name = "ChooseCourseBox";
            ChooseCourseBox.Size = new Size(100, 23);
            ChooseCourseBox.TabIndex = 12;
            ChooseCourseBox.Text = "course";
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(333, 197);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(100, 23);
            AssignButton.TabIndex = 11;
            AssignButton.Text = "Assign";
            AssignButton.UseVisualStyleBackColor = true;
            AssignButton.Click += AssignButton_Click;
            // 
            // ChooseLecturerBox
            // 
            ChooseLecturerBox.FormattingEnabled = true;
            ChooseLecturerBox.Location = new Point(333, 139);
            ChooseLecturerBox.Name = "ChooseLecturerBox";
            ChooseLecturerBox.Size = new Size(100, 23);
            ChooseLecturerBox.TabIndex = 10;
            ChooseLecturerBox.Text = "lecturer";
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
            // AssignLecturerToCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AssignLecturerToCourseForm";
            Text = "AssignLecturerToCourseForm";
            panelForms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private Button AssignButton;
        private ComboBox ChooseLecturerBox;
        private Button BackButton;
        private ComboBox ChooseCourseBox;
    }
}