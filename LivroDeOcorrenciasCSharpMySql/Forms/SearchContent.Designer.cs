namespace LivroDeOcorrenciasCSharpMySql.Forms
{
    partial class SearchContent
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
            dateTimePicker1 = new DateTimePicker();
            getDateButton = new Button();
            positionComboBox = new ComboBox();
            button2 = new Button();
            getPositionButton = new Button();
            dateTextBox = new TextBox();
            positionTextBox = new TextBox();
            firstNameComboBox = new ComboBox();
            button4 = new Button();
            getFirstNameButton = new Button();
            firstNameTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            shift = new DataGridViewTextBoxColumn();
            shiftComboBox = new ComboBox();
            getShiftButton = new Button();
            shiftTextBox = new TextBox();
            button7 = new Button();
            label1 = new Label();
            shiftsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(108, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // getDateButton
            // 
            getDateButton.Location = new Point(314, 57);
            getDateButton.Name = "getDateButton";
            getDateButton.Size = new Size(75, 23);
            getDateButton.TabIndex = 1;
            getDateButton.Text = "Procurar";
            getDateButton.UseVisualStyleBackColor = true;
            getDateButton.Click += getDateButton_Click;
            // 
            // positionComboBox
            // 
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Location = new Point(108, 86);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(200, 23);
            positionComboBox.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(27, 85);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cargos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // getPositionButton
            // 
            getPositionButton.Location = new Point(314, 86);
            getPositionButton.Name = "getPositionButton";
            getPositionButton.Size = new Size(75, 23);
            getPositionButton.TabIndex = 4;
            getPositionButton.Text = "Procurar";
            getPositionButton.UseVisualStyleBackColor = true;
            getPositionButton.Click += getPositionButton_Click;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(395, 57);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.ReadOnly = true;
            dateTextBox.Size = new Size(200, 23);
            dateTextBox.TabIndex = 5;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(395, 87);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.ReadOnly = true;
            positionTextBox.Size = new Size(200, 23);
            positionTextBox.TabIndex = 6;
            // 
            // firstNameComboBox
            // 
            firstNameComboBox.FormattingEnabled = true;
            firstNameComboBox.Location = new Point(108, 115);
            firstNameComboBox.Name = "firstNameComboBox";
            firstNameComboBox.Size = new Size(200, 23);
            firstNameComboBox.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(27, 115);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Nomes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // getFirstNameButton
            // 
            getFirstNameButton.Location = new Point(314, 115);
            getFirstNameButton.Name = "getFirstNameButton";
            getFirstNameButton.Size = new Size(75, 23);
            getFirstNameButton.TabIndex = 9;
            getFirstNameButton.Text = "Procurar";
            getFirstNameButton.UseVisualStyleBackColor = true;
            getFirstNameButton.Click += getFirstNameButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(395, 116);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.ReadOnly = true;
            firstNameTextBox.Size = new Size(200, 23);
            firstNameTextBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Position, FirstName, shift });
            dataGridView1.Location = new Point(27, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(568, 370);
            dataGridView1.TabIndex = 11;
            // 
            // Date
            // 
            Date.HeaderText = "Data";
            Date.Name = "Date";
            Date.Width = 70;
            // 
            // Position
            // 
            Position.HeaderText = "Cargo";
            Position.Name = "Position";
            Position.Width = 150;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Nome";
            FirstName.Name = "FirstName";
            FirstName.Width = 190;
            // 
            // shift
            // 
            shift.HeaderText = "Turno";
            shift.Name = "shift";
            shift.Width = 115;
            // 
            // shiftComboBox
            // 
            shiftComboBox.FormattingEnabled = true;
            shiftComboBox.Location = new Point(108, 144);
            shiftComboBox.Name = "shiftComboBox";
            shiftComboBox.Size = new Size(200, 23);
            shiftComboBox.TabIndex = 12;
            // 
            // getShiftButton
            // 
            getShiftButton.Location = new Point(314, 143);
            getShiftButton.Name = "getShiftButton";
            getShiftButton.Size = new Size(75, 23);
            getShiftButton.TabIndex = 13;
            getShiftButton.Text = "Procurar";
            getShiftButton.UseVisualStyleBackColor = true;
            getShiftButton.Click += getShiftButton_Click;
            // 
            // shiftTextBox
            // 
            shiftTextBox.Location = new Point(395, 145);
            shiftTextBox.Name = "shiftTextBox";
            shiftTextBox.ReadOnly = true;
            shiftTextBox.Size = new Size(200, 23);
            shiftTextBox.TabIndex = 14;
            // 
            // button7
            // 
            button7.Location = new Point(465, 550);
            button7.Name = "button7";
            button7.Size = new Size(130, 23);
            button7.TabIndex = 15;
            button7.Text = "Pesquisa Detalhada";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(69, 63);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 16;
            label1.Text = "Data";
            // 
            // shiftsButton
            // 
            shiftsButton.Location = new Point(27, 143);
            shiftsButton.Name = "shiftsButton";
            shiftsButton.Size = new Size(75, 23);
            shiftsButton.TabIndex = 17;
            shiftsButton.Text = "Turnos";
            shiftsButton.UseVisualStyleBackColor = true;
            shiftsButton.Click += shiftsButton_Click;
            // 
            // SearchContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(shiftsButton);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(shiftTextBox);
            Controls.Add(getShiftButton);
            Controls.Add(shiftComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(firstNameTextBox);
            Controls.Add(getFirstNameButton);
            Controls.Add(button4);
            Controls.Add(firstNameComboBox);
            Controls.Add(positionTextBox);
            Controls.Add(dateTextBox);
            Controls.Add(getPositionButton);
            Controls.Add(button2);
            Controls.Add(positionComboBox);
            Controls.Add(getDateButton);
            Controls.Add(dateTimePicker1);
            Name = "SearchContent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchContent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button getDateButton;
        private ComboBox positionComboBox;
        private Button button2;
        private Button getPositionButton;
        private TextBox dateTextBox;
        private TextBox positionTextBox;
        private ComboBox firstNameComboBox;
        private Button button4;
        private Button getFirstNameButton;
        private TextBox firstNameTextBox;
        private DataGridView dataGridView1;
        private ComboBox shiftComboBox;
        private Button getShiftButton;
        private TextBox shiftTextBox;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn shift;
        private Button button7;
        private Label label1;
        private Button shiftsButton;
    }
}