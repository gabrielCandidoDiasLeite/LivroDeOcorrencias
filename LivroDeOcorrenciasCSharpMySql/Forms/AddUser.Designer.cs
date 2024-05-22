namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    partial class AddUser
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            positionLabel = new Label();
            positionComboBox = new ComboBox();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            checkPasswordTextBox = new TextBox();
            checkPasswordLabel = new Label();
            userLevelComboBox = new ComboBox();
            label2 = new Label();
            addButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar novo usuário";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F);
            firstNameLabel.Location = new Point(12, 51);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(117, 21);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Primeiro Nome";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 75);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "Bruce";
            firstNameTextBox.Size = new Size(253, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 125);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Wayne";
            lastNameTextBox.Size = new Size(253, 23);
            lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F);
            lastNameLabel.Location = new Point(12, 101);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(104, 21);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Último Nome";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Segoe UI", 12F);
            positionLabel.Location = new Point(12, 151);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(52, 21);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Cargo";
            // 
            // positionComboBox
            // 
            positionComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Desenvolvedor", "Gestor", "Supervisor", "Assistente", "Operador" });
            positionComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            positionComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Items.AddRange(new object[] { "Desenvolvedor", "Gestor", "Supervisor", "Assistente", "Operador" });
            positionComboBox.Location = new Point(12, 175);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(253, 23);
            positionComboBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 225);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "batman@gotham.com";
            emailTextBox.Size = new Size(253, 23);
            emailTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F);
            emailLabel.Location = new Point(12, 201);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 21);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "E-mail";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 275);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "#1234Senha";
            passwordTextBox.Size = new Size(253, 23);
            passwordTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F);
            passwordLabel.Location = new Point(12, 251);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(53, 21);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Senha";
            // 
            // checkPasswordTextBox
            // 
            checkPasswordTextBox.Location = new Point(11, 325);
            checkPasswordTextBox.Name = "checkPasswordTextBox";
            checkPasswordTextBox.PlaceholderText = "#1234Senha";
            checkPasswordTextBox.Size = new Size(253, 23);
            checkPasswordTextBox.TabIndex = 12;
            // 
            // checkPasswordLabel
            // 
            checkPasswordLabel.AutoSize = true;
            checkPasswordLabel.Font = new Font("Segoe UI", 12F);
            checkPasswordLabel.Location = new Point(11, 301);
            checkPasswordLabel.Name = "checkPasswordLabel";
            checkPasswordLabel.Size = new Size(190, 21);
            checkPasswordLabel.TabIndex = 11;
            checkPasswordLabel.Text = "Digite a senha novamente";
            // 
            // userLevelComboBox
            // 
            userLevelComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Administrador", "Usuário", "Leitor" });
            userLevelComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            userLevelComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            userLevelComboBox.FormattingEnabled = true;
            userLevelComboBox.Items.AddRange(new object[] { "Administrador", "Usuário", "Leitor" });
            userLevelComboBox.Location = new Point(11, 375);
            userLevelComboBox.Name = "userLevelComboBox";
            userLevelComboBox.Size = new Size(253, 23);
            userLevelComboBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 351);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 13;
            label2.Text = "Nível de Usuário";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 404);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 35);
            addButton.TabIndex = 15;
            addButton.Text = "Adicionar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(189, 404);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 35);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 446);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(userLevelComboBox);
            Controls.Add(label2);
            Controls.Add(checkPasswordTextBox);
            Controls.Add(checkPasswordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(positionComboBox);
            Controls.Add(positionLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(label1);
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Label positionLabel;
        private ComboBox positionComboBox;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox checkPasswordTextBox;
        private Label checkPasswordLabel;
        private ComboBox userLevelComboBox;
        private Label label2;
        private Button addButton;
        private Button cancelButton;
    }
}