namespace kotyk
{
    partial class LecturerForm
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
            ManageGradesButton = new Button();
            HelloLabel = new Label();
            panelForms = new Panel();
            LecturerPicBox = new PictureBox();
            panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LecturerPicBox).BeginInit();
            SuspendLayout();
            // 
            // ManageGradesButton
            // 
            ManageGradesButton.Location = new Point(58, 123);
            ManageGradesButton.Name = "ManageGradesButton";
            ManageGradesButton.Size = new Size(98, 23);
            ManageGradesButton.TabIndex = 1;
            ManageGradesButton.Text = "Manage grades";
            ManageGradesButton.UseVisualStyleBackColor = true;
            ManageGradesButton.Click += ManageGradesButton_Click;
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
            // panelForms
            // 
            panelForms.Controls.Add(LecturerPicBox);
            panelForms.Controls.Add(ManageGradesButton);
            panelForms.Controls.Add(HelloLabel);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 3;
            // 
            // LecturerPicBox
            // 
            LecturerPicBox.Image = Properties.Resources.lecturerbig;
            LecturerPicBox.Location = new Point(438, 12);
            LecturerPicBox.Name = "LecturerPicBox";
            LecturerPicBox.Size = new Size(350, 426);
            LecturerPicBox.TabIndex = 6;
            LecturerPicBox.TabStop = false;
            // 
            // LecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "LecturerForm";
            Text = "LecturerForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LecturerPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ManageGradesButton;
        private Label HelloLabel;
        private Panel panelForms;
        private PictureBox LecturerPicBox;
    }
}