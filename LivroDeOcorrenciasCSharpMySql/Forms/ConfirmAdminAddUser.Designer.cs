namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    partial class ConfirmAdminAddUser
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
            label1 = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 21);
            label1.TabIndex = 0;
            label1.Text = "Digite o login e senha de administrador!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(32, 45);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Digite o e-mail...";
            emailTextBox.Size = new Size(317, 23);
            emailTextBox.TabIndex = 1;
            emailTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(32, 74);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Digite a senha...";
            passwordTextBox.Size = new Size(317, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // okButton
            // 
            okButton.Location = new Point(115, 103);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 35);
            okButton.TabIndex = 3;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(196, 103);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 35);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ConfirmAdminAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 157);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ConfirmAdminAddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmAdminAddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button okButton;
        private Button cancelButton;
    }
}