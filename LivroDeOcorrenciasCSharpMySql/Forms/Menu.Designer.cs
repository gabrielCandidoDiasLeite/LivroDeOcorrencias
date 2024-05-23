namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    partial class Menu
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
            button1 = new Button();
            onButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 0;
            label1.Text = "Teste";
            // 
            // button1
            // 
            button1.Location = new Point(118, 33);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 1;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // onButton
            // 
            onButton.Location = new Point(12, 33);
            onButton.Name = "onButton";
            onButton.Size = new Size(100, 35);
            onButton.TabIndex = 2;
            onButton.Text = "Livro";
            onButton.UseVisualStyleBackColor = true;
            onButton.Click += onButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(onButton);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button onButton;
    }
}