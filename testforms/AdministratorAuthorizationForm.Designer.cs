namespace kotyk
{
    partial class AdministratorAuthorizationForm
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
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            panelForms = new Panel();
            panelForms.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.ForeColor = SystemColors.GrayText;
            UsernameTextBox.Location = new Point(321, 172);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(100, 23);
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.Text = "username";
            UsernameTextBox.Enter += UsernameTextBox_Enter;
            UsernameTextBox.Leave += UsernameTextBox_Leave;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.ForeColor = SystemColors.GrayText;
            PasswordTextBox.Location = new Point(321, 201);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Text = "password";
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(346, 230);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // panelForms
            // 
            panelForms.Controls.Add(UsernameTextBox);
            panelForms.Controls.Add(LoginButton);
            panelForms.Controls.Add(PasswordTextBox);
            panelForms.Location = new Point(0, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(800, 450);
            panelForms.TabIndex = 3;
            // 
            // AdministratorAuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Name = "AdministratorAuthorizationForm";
            Text = "Administrator Authorization Form";
            panelForms.ResumeLayout(false);
            panelForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Panel panelForms;
    }
}