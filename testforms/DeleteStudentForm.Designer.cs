﻿namespace kotyk
{
    partial class DeleteStudentForm
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
            DeleteButton = new Button();
            ChooseStudentBox = new ComboBox();
            BackButton = new Button();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(DeleteButton);
            panelForms.Controls.Add(ChooseStudentBox);
            panelForms.Controls.Add(BackButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 7;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(333, 197);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(100, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChooseStudentBox
            // 
            ChooseStudentBox.FormattingEnabled = true;
            ChooseStudentBox.Location = new Point(333, 168);
            ChooseStudentBox.Name = "ChooseStudentBox";
            ChooseStudentBox.Size = new Size(100, 23);
            ChooseStudentBox.TabIndex = 10;
            ChooseStudentBox.Text = "student";
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
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "DeleteStudentForm";
            Text = "DeleteStudentForm";
            panelForms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private Button DeleteButton;
        private ComboBox ChooseStudentBox;
        private Button BackButton;
    }
}