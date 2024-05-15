namespace LivroDeOcorrenciasCSharpMySql
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            pictureBox1 = new PictureBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            loginButton = new Button();
            addUserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(760, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top;
            emailLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            emailLabel.Location = new Point(350, 371);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(100, 35);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "E-mail";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            emailLabel.UseCompatibleTextRendering = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top;
            emailTextBox.Location = new Point(200, 409);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Digite seu e-mail...";
            emailTextBox.Size = new Size(400, 23);
            emailTextBox.TabIndex = 2;
            emailTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top;
            passwordTextBox.Location = new Point(200, 473);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Digite sua senha...";
            passwordTextBox.Size = new Size(400, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top;
            passwordLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            passwordLabel.Location = new Point(350, 435);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 35);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Senha";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            passwordLabel.UseCompatibleTextRendering = true;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Location = new Point(300, 502);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 35);
            loginButton.TabIndex = 5;
            loginButton.Text = "Entrar";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            addUserButton.Anchor = AnchorStyles.Top;
            addUserButton.Location = new Point(400, 502);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(100, 35);
            addUserButton.TabIndex = 6;
            addUserButton.Text = "Novo Usuário";
            addUserButton.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(addUserButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Index";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livro de Ocorrências";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button addUserButton;
    }
}
