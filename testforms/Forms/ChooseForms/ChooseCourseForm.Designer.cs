namespace kotyk
{
    partial class ChooseCourseForm
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
            ChooseCourseBox = new ComboBox();
            ChooseCourseButton = new Button();
            panelForms = new Panel();
            ChooseCourseLabel = new Label();
            BackButton = new Button();
            LecturerLabel = new Label();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // ChooseCourseBox
            // 
            ChooseCourseBox.FormattingEnabled = true;
            ChooseCourseBox.Location = new Point(267, 175);
            ChooseCourseBox.Name = "ChooseCourseBox";
            ChooseCourseBox.Size = new Size(121, 23);
            ChooseCourseBox.TabIndex = 0;
            ChooseCourseBox.Text = "Choose course";
            // 
            // ChooseCourseButton
            // 
            ChooseCourseButton.Location = new Point(394, 175);
            ChooseCourseButton.Name = "ChooseCourseButton";
            ChooseCourseButton.Size = new Size(75, 23);
            ChooseCourseButton.TabIndex = 1;
            ChooseCourseButton.Text = "OK";
            ChooseCourseButton.UseVisualStyleBackColor = true;
            ChooseCourseButton.Click += ChooseCourseButton_Click;
            // 
            // panelForms
            // 
            panelForms.Controls.Add(ChooseCourseLabel);
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(LecturerLabel);
            panelForms.Controls.Add(ChooseCourseBox);
            panelForms.Controls.Add(ChooseCourseButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 2;
            // 
            // ChooseCourseLabel
            // 
            ChooseCourseLabel.AutoSize = true;
            ChooseCourseLabel.Location = new Point(267, 157);
            ChooseCourseLabel.Name = "ChooseCourseLabel";
            ChooseCourseLabel.Size = new Size(44, 15);
            ChooseCourseLabel.TabIndex = 4;
            ChooseCourseLabel.Text = "Course";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
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
            // ChooseCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "ChooseCourseForm";
            Text = "ChooseCourseForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ChooseCourseBox;
        private Button ChooseCourseButton;
        private Panel panelForms;
        private Label LecturerLabel;
        private Button BackButton;
        private Label ChooseCourseLabel;
    }
}