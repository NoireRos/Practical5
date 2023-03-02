namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleInitialText = new System.Windows.Forms.TextBox();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.dateOfBirthText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.completeAddressLabel = new System.Windows.Forms.Label();
            this.barangayText = new System.Windows.Forms.TextBox();
            this.barangayLabel = new System.Windows.Forms.Label();
            this.precintNoLabel = new System.Windows.Forms.Label();
            this.precintCombo = new System.Windows.Forms.ComboBox();
            this.voteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.birthplaceText = new System.Windows.Forms.TextBox();
            this.birthplaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CASTING FOR VOTE";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(27, 49);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.Color.White;
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(30, 68);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 22);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.Color.White;
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(199, 68);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 22);
            this.lastNameText.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(196, 49);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(67, 15);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // middleInitialText
            // 
            this.middleInitialText.BackColor = System.Drawing.Color.White;
            this.middleInitialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialText.Location = new System.Drawing.Point(361, 68);
            this.middleInitialText.Name = "middleInitialText";
            this.middleInitialText.Size = new System.Drawing.Size(100, 22);
            this.middleInitialText.TabIndex = 6;
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.AutoSize = true;
            this.middleInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialLabel.Location = new System.Drawing.Point(358, 49);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(77, 15);
            this.middleInitialLabel.TabIndex = 5;
            this.middleInitialLabel.Text = "Middle Initial";
            // 
            // dateOfBirthText
            // 
            this.dateOfBirthText.AutoSize = true;
            this.dateOfBirthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthText.Location = new System.Drawing.Point(27, 120);
            this.dateOfBirthText.Name = "dateOfBirthText";
            this.dateOfBirthText.Size = new System.Drawing.Size(80, 15);
            this.dateOfBirthText.TabIndex = 7;
            this.dateOfBirthText.Text = "Date of Birth: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(338, 124);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(31, 15);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(375, 120);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 10;
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(142, 217);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(227, 22);
            this.addressText.TabIndex = 12;
            // 
            // completeAddressLabel
            // 
            this.completeAddressLabel.AutoSize = true;
            this.completeAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeAddressLabel.Location = new System.Drawing.Point(26, 220);
            this.completeAddressLabel.Name = "completeAddressLabel";
            this.completeAddressLabel.Size = new System.Drawing.Size(110, 15);
            this.completeAddressLabel.TabIndex = 11;
            this.completeAddressLabel.Text = "Complete Address:";
            // 
            // barangayText
            // 
            this.barangayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayText.Location = new System.Drawing.Point(142, 248);
            this.barangayText.Name = "barangayText";
            this.barangayText.Size = new System.Drawing.Size(227, 22);
            this.barangayText.TabIndex = 14;
            // 
            // barangayLabel
            // 
            this.barangayLabel.AutoSize = true;
            this.barangayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayLabel.Location = new System.Drawing.Point(26, 251);
            this.barangayLabel.Name = "barangayLabel";
            this.barangayLabel.Size = new System.Drawing.Size(62, 15);
            this.barangayLabel.TabIndex = 13;
            this.barangayLabel.Text = "Barangay:";
            // 
            // precintNoLabel
            // 
            this.precintNoLabel.AutoSize = true;
            this.precintNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precintNoLabel.Location = new System.Drawing.Point(26, 279);
            this.precintNoLabel.Name = "precintNoLabel";
            this.precintNoLabel.Size = new System.Drawing.Size(67, 15);
            this.precintNoLabel.TabIndex = 15;
            this.precintNoLabel.Text = "Precint No:";
            // 
            // precintCombo
            // 
            this.precintCombo.FormattingEnabled = true;
            this.precintCombo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
            "009",
            "010",
            "011"});
            this.precintCombo.Location = new System.Drawing.Point(142, 279);
            this.precintCombo.Name = "precintCombo";
            this.precintCombo.Size = new System.Drawing.Size(121, 21);
            this.precintCombo.TabIndex = 16;
            // 
            // voteButton
            // 
            this.voteButton.BackColor = System.Drawing.Color.White;
            this.voteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voteButton.ForeColor = System.Drawing.Color.Black;
            this.voteButton.Location = new System.Drawing.Point(29, 334);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(88, 41);
            this.voteButton.TabIndex = 17;
            this.voteButton.Text = "VOTE";
            this.voteButton.UseVisualStyleBackColor = false;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(175, 334);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 41);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(317, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 41);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sex:";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(142, 152);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(121, 21);
            this.sexComboBox.TabIndex = 22;
            // 
            // birthplaceText
            // 
            this.birthplaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthplaceText.Location = new System.Drawing.Point(142, 184);
            this.birthplaceText.Name = "birthplaceText";
            this.birthplaceText.Size = new System.Drawing.Size(227, 22);
            this.birthplaceText.TabIndex = 24;
            // 
            // birthplaceLabel
            // 
            this.birthplaceLabel.AutoSize = true;
            this.birthplaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthplaceLabel.Location = new System.Drawing.Point(26, 187);
            this.birthplaceLabel.Name = "birthplaceLabel";
            this.birthplaceLabel.Size = new System.Drawing.Size(69, 15);
            this.birthplaceLabel.TabIndex = 23;
            this.birthplaceLabel.Text = "Birth Place:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(503, 412);
            this.Controls.Add(this.birthplaceText);
            this.Controls.Add(this.birthplaceLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.precintCombo);
            this.Controls.Add(this.precintNoLabel);
            this.Controls.Add(this.barangayText);
            this.Controls.Add(this.barangayLabel);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.completeAddressLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateOfBirthText);
            this.Controls.Add(this.middleInitialText);
            this.Controls.Add(this.middleInitialLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox middleInitialText;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Label dateOfBirthText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label completeAddressLabel;
        private System.Windows.Forms.TextBox barangayText;
        private System.Windows.Forms.Label barangayLabel;
        private System.Windows.Forms.Label precintNoLabel;
        private System.Windows.Forms.ComboBox precintCombo;
        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox birthplaceText;
        private System.Windows.Forms.Label birthplaceLabel;
    }
}

