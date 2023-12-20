namespace kotyk
{
    partial class AddGradeForm
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
            GradesGrid = new DataGridView();
            BackButton = new Button();
            panelForms = new Panel();
            ((System.ComponentModel.ISupportInitialize)GradesGrid).BeginInit();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // GradesGrid
            // 
            GradesGrid.AllowUserToAddRows = false;
            GradesGrid.AllowUserToDeleteRows = false;
            GradesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GradesGrid.Location = new Point(12, 42);
            GradesGrid.Name = "GradesGrid";
            GradesGrid.ReadOnly = true;
            GradesGrid.Size = new Size(764, 384);
            GradesGrid.TabIndex = 0;
            GradesGrid.CellEndEdit += GradesGrid_CellEndEdit;
            GradesGrid.CellValidating += GradesGrid_CellValidating;
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
            // panelForms
            // 
            panelForms.Controls.Add(GradesGrid);
            panelForms.Controls.Add(BackButton);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 3;
            // 
            // AddGradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AddGradeForm";
            Text = "Add Grade";
            ((System.ComponentModel.ISupportInitialize)GradesGrid).EndInit();
            panelForms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GradesGrid;
        private Button BackButton;
        private Panel panelForms;
    }
}