namespace testforms
{
    partial class AdministratorForm
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
            AddButton = new Button();
            HelloLabel = new Label();
            panelForms = new Panel();
            AdministratorPicBox = new PictureBox();
            ViewButton = new Button();
            AssignButton = new Button();
            DeleteButton = new Button();
            BackButton = new Button();
            panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdministratorPicBox).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(58, 123);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
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
            panelForms.Controls.Add(BackButton);
            panelForms.Controls.Add(AdministratorPicBox);
            panelForms.Controls.Add(ViewButton);
            panelForms.Controls.Add(AssignButton);
            panelForms.Controls.Add(DeleteButton);
            panelForms.Controls.Add(AddButton);
            panelForms.Controls.Add(HelloLabel);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 4;
            // 
            // AdministratorPicBox
            // 
            AdministratorPicBox.Image = kotyk.Properties.Resources.administratorbig;
            AdministratorPicBox.Location = new Point(438, 12);
            AdministratorPicBox.Name = "AdministratorPicBox";
            AdministratorPicBox.Size = new Size(350, 426);
            AdministratorPicBox.TabIndex = 5;
            AdministratorPicBox.TabStop = false;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(58, 210);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(98, 23);
            ViewButton.TabIndex = 4;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(58, 181);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(98, 23);
            AssignButton.TabIndex = 3;
            AssignButton.Text = "Assign";
            AssignButton.UseVisualStyleBackColor = true;
            AssignButton.Click += AssignButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(58, 152);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdministratorPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Label HelloLabel;
        private Panel panelForms;
        private Button DeleteButton;
        private Button AssignButton;
        private Button ViewButton;
        private PictureBox AdministratorPicBox;
        private Button BackButton;
    }
}