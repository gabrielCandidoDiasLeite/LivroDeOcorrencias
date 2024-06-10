namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    partial class DailyContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyContent));
            headerLabel = new Label();
            contentTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            pictureBox4 = new PictureBox();
            clearImagesButton = new Button();
            endButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(784, 25);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Desenvolvedor Gabriel, 23/05/2024, turno matutino.";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentTextBox
            // 
            contentTextBox.Location = new Point(12, 59);
            contentTextBox.Multiline = true;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.PlaceholderText = "Digite o conteúdo do dia aqui...";
            contentTextBox.ScrollBars = ScrollBars.Vertical;
            contentTextBox.Size = new Size(538, 594);
            contentTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "D:\\Gabriel Leite\\Green Eye Dev\\Livro de Ocorrências\\livrodeocorrencias\\LivroDeOcorrencias\\LivroDeOcorrenciasCSharpMySql\\Imgs\\GreenEye.png";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(556, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(556, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(556, 359);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(556, 509);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(216, 144);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // clearImagesButton
            // 
            clearImagesButton.Location = new Point(672, 659);
            clearImagesButton.Name = "clearImagesButton";
            clearImagesButton.Size = new Size(100, 35);
            clearImagesButton.TabIndex = 7;
            clearImagesButton.Text = "Limpar Imagens";
            clearImagesButton.UseVisualStyleBackColor = true;
            clearImagesButton.Click += clearImagesButton_Click;
            // 
            // endButton
            // 
            endButton.Location = new Point(450, 659);
            endButton.Name = "endButton";
            endButton.Size = new Size(100, 35);
            endButton.TabIndex = 8;
            endButton.Text = "Finalizar";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += endButton_Click;
            // 
            // DailyContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(endButton);
            Controls.Add(clearImagesButton);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(contentTextBox);
            Controls.Add(headerLabel);
            Name = "DailyContent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DailyContent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox contentTextBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private PictureBox pictureBox4;
        private Button clearImagesButton;
        private Button endButton;
    }
}