namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    partial class ShowContent
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
            contentTextBox = new TextBox();
            headerLabel = new Label();
            image1pictureBox = new PictureBox();
            image2pictureBox = new PictureBox();
            image3pictureBox = new PictureBox();
            image4pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)image1pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image2pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image3pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image4pictureBox).BeginInit();
            SuspendLayout();
            // 
            // contentTextBox
            // 
            contentTextBox.Location = new Point(43, 28);
            contentTextBox.Multiline = true;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.ReadOnly = true;
            contentTextBox.ScrollBars = ScrollBars.Vertical;
            contentTextBox.Size = new Size(683, 349);
            contentTextBox.TabIndex = 0;
            contentTextBox.Text = "Teste de texto.";
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(784, 25);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Desenvolvedor Gabriel, 26/05/20224, turno noturno";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // image1pictureBox
            // 
            image1pictureBox.Location = new Point(43, 383);
            image1pictureBox.Name = "image1pictureBox";
            image1pictureBox.Size = new Size(320, 180);
            image1pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            image1pictureBox.TabIndex = 2;
            image1pictureBox.TabStop = false;
            // 
            // image2pictureBox
            // 
            image2pictureBox.Location = new Point(406, 383);
            image2pictureBox.Name = "image2pictureBox";
            image2pictureBox.Size = new Size(320, 180);
            image2pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            image2pictureBox.TabIndex = 3;
            image2pictureBox.TabStop = false;
            // 
            // image3pictureBox
            // 
            image3pictureBox.Location = new Point(43, 569);
            image3pictureBox.Name = "image3pictureBox";
            image3pictureBox.Size = new Size(320, 180);
            image3pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            image3pictureBox.TabIndex = 4;
            image3pictureBox.TabStop = false;
            // 
            // image4pictureBox
            // 
            image4pictureBox.Location = new Point(406, 569);
            image4pictureBox.Name = "image4pictureBox";
            image4pictureBox.Size = new Size(320, 180);
            image4pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            image4pictureBox.TabIndex = 5;
            image4pictureBox.TabStop = false;
            // 
            // ShowContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(image4pictureBox);
            Controls.Add(image3pictureBox);
            Controls.Add(image2pictureBox);
            Controls.Add(image1pictureBox);
            Controls.Add(headerLabel);
            Controls.Add(contentTextBox);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ShowContent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowContent";
            ((System.ComponentModel.ISupportInitialize)image1pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)image2pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)image3pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)image4pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contentTextBox;
        private Label headerLabel;
        private PictureBox image1pictureBox;
        private PictureBox image2pictureBox;
        private PictureBox image3pictureBox;
        private PictureBox image4pictureBox;
    }
}