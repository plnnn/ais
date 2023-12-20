namespace testforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdministratorButton = new Button();
            LecturerButton = new Button();
            StudentButton = new Button();
            panelForms = new Panel();
            AdministratorPicBox = new PictureBox();
            LecturerPicBox = new PictureBox();
            StudentPicBox = new PictureBox();
            panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdministratorPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LecturerPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentPicBox).BeginInit();
            SuspendLayout();
            // 
            // AdministratorButton
            // 
            AdministratorButton.Location = new Point(82, 325);
            AdministratorButton.Name = "AdministratorButton";
            AdministratorButton.Size = new Size(109, 23);
            AdministratorButton.TabIndex = 1;
            AdministratorButton.Text = "Administrator";
            AdministratorButton.UseVisualStyleBackColor = true;
            AdministratorButton.Click += AdministratorButton_Click;
            // 
            // LecturerButton
            // 
            LecturerButton.Location = new Point(359, 325);
            LecturerButton.Name = "LecturerButton";
            LecturerButton.Size = new Size(75, 23);
            LecturerButton.TabIndex = 2;
            LecturerButton.Text = "Lecturer";
            LecturerButton.UseVisualStyleBackColor = true;
            LecturerButton.Click += LecturerButton_Click;
            // 
            // StudentButton
            // 
            StudentButton.Location = new Point(619, 325);
            StudentButton.Name = "StudentButton";
            StudentButton.Size = new Size(75, 23);
            StudentButton.TabIndex = 3;
            StudentButton.Text = "Student";
            StudentButton.UseVisualStyleBackColor = true;
            StudentButton.Click += StudentButton_Click;
            // 
            // panelForms
            // 
            panelForms.Controls.Add(StudentPicBox);
            panelForms.Controls.Add(LecturerPicBox);
            panelForms.Controls.Add(AdministratorPicBox);
            panelForms.Controls.Add(LecturerButton);
            panelForms.Controls.Add(StudentButton);
            panelForms.Controls.Add(AdministratorButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 4;
            // 
            // AdministratorPicBox
            // 
            AdministratorPicBox.Image = kotyk.Properties.Resources.administrator;
            AdministratorPicBox.Location = new Point(44, 69);
            AdministratorPicBox.Name = "AdministratorPicBox";
            AdministratorPicBox.Size = new Size(200, 250);
            AdministratorPicBox.TabIndex = 4;
            AdministratorPicBox.TabStop = false;
            // 
            // LecturerPicBox
            // 
            LecturerPicBox.Image = kotyk.Properties.Resources.lecturer;
            LecturerPicBox.Location = new Point(299, 69);
            LecturerPicBox.Name = "LecturerPicBox";
            LecturerPicBox.Size = new Size(200, 250);
            LecturerPicBox.TabIndex = 5;
            LecturerPicBox.TabStop = false;
            // 
            // StudentPicBox
            // 
            StudentPicBox.Image = kotyk.Properties.Resources.student;
            StudentPicBox.Location = new Point(555, 69);
            StudentPicBox.Name = "StudentPicBox";
            StudentPicBox.Size = new Size(200, 250);
            StudentPicBox.TabIndex = 6;
            StudentPicBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "MainForm";
            Text = "AIS";
            Load += MainForm_Load;
            panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdministratorPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LecturerPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button AdministratorButton;
        private Button LecturerButton;
        private Button StudentButton;
        private Panel panelForms;
        private PictureBox StudentPicBox;
        private PictureBox LecturerPicBox;
        private PictureBox AdministratorPicBox;
    }
}
