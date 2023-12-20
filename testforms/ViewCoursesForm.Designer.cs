namespace kotyk
{
    partial class ViewCoursesForm
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
            CoursesGrid = new DataGridView();
            BackButton = new Button();
            panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoursesGrid).BeginInit();
            SuspendLayout();
            // 
            // panelForms
            // 
            panelForms.Controls.Add(CoursesGrid);
            panelForms.Controls.Add(BackButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 5;
            // 
            // CoursesGrid
            // 
            CoursesGrid.AllowUserToAddRows = false;
            CoursesGrid.AllowUserToDeleteRows = false;
            CoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesGrid.Location = new Point(12, 42);
            CoursesGrid.Name = "CoursesGrid";
            CoursesGrid.ReadOnly = true;
            CoursesGrid.Size = new Size(764, 384);
            CoursesGrid.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 13);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ViewCoursesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "ViewCoursesForm";
            Text = "ViewCoursesForm";
            panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CoursesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForms;
        private DataGridView CoursesGrid;
        private Button BackButton;
    }
}