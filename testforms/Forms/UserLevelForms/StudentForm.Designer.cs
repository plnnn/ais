namespace kotyk
{
    partial class StudentForm
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
            HelloLabel = new Label();
            ViewGradesButton = new Button();
            panelForms = new Panel();
            StudentPicBox = new PictureBox();
            BackButton = new Button();
            panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentPicBox).BeginInit();
            SuspendLayout();
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Location = new Point(58, 72);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(35, 15);
            HelloLabel.TabIndex = 0;
            HelloLabel.Text = "Hello";
            // 
            // ViewGradesButton
            // 
            ViewGradesButton.Location = new Point(58, 123);
            ViewGradesButton.Name = "ViewGradesButton";
            ViewGradesButton.Size = new Size(98, 23);
            ViewGradesButton.TabIndex = 1;
            ViewGradesButton.Text = "View grades";
            ViewGradesButton.UseVisualStyleBackColor = true;
            ViewGradesButton.Click += ViewGradesButton_Click;
            // 
            // panelForms
            // 
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(StudentPicBox);
            panelForms.Controls.Add(ViewGradesButton);
            panelForms.Controls.Add(HelloLabel);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 2;
            // 
            // StudentPicBox
            // 
            StudentPicBox.Image = Properties.Resources.studentbig;
            StudentPicBox.Location = new Point(438, 12);
            StudentPicBox.Name = "StudentPicBox";
            StudentPicBox.Size = new Size(350, 426);
            StudentPicBox.TabIndex = 6;
            StudentPicBox.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "StudentForm";
            Text = "StudentForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label HelloLabel;
        private Button ViewGradesButton;
        private Panel panelForms;
        private PictureBox StudentPicBox;
        private Button BackButton;
    }
}