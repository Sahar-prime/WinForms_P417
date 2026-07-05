namespace HW_2
{
    partial class Form1
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            usersListBox = new ListBox();
            exportTxtButton = new Button();
            importTxtButton = new Button();
            exportXmlButton = new Button();
            importXmlButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 28);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(34, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Имя:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(79, 25);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(79, 54);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 57);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(61, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Фамилия:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(79, 83);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 86);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 15);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "E-mail:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(79, 112);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(100, 23);
            phoneTextBox.TabIndex = 7;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(12, 115);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(58, 15);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Телефон:";
            // 
            // addButton
            // 
            addButton.Location = new Point(41, 141);
            addButton.Name = "addButton";
            addButton.Size = new Size(108, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(41, 170);
            editButton.Name = "editButton";
            editButton.Size = new Size(108, 23);
            editButton.TabIndex = 9;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(41, 199);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(108, 23);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // usersListBox
            // 
            usersListBox.FormattingEnabled = true;
            usersListBox.Location = new Point(218, 12);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(500, 199);
            usersListBox.TabIndex = 11;
            usersListBox.SelectedIndexChanged += usersListBox_SelectedIndexChanged;
            // 
            // exportTxtButton
            // 
            exportTxtButton.Location = new Point(236, 217);
            exportTxtButton.Name = "exportTxtButton";
            exportTxtButton.Size = new Size(108, 23);
            exportTxtButton.TabIndex = 12;
            exportTxtButton.Text = "Экспорт в TXT";
            exportTxtButton.UseVisualStyleBackColor = true;
            exportTxtButton.Click += exportTxtButton_Click;
            // 
            // importTxtButton
            // 
            importTxtButton.Location = new Point(350, 217);
            importTxtButton.Name = "importTxtButton";
            importTxtButton.Size = new Size(111, 23);
            importTxtButton.TabIndex = 13;
            importTxtButton.Text = "Импорт из TXT";
            importTxtButton.UseVisualStyleBackColor = true;
            importTxtButton.Click += importTxtButton_Click;
            // 
            // exportXmlButton
            // 
            exportXmlButton.Location = new Point(467, 217);
            exportXmlButton.Name = "exportXmlButton";
            exportXmlButton.Size = new Size(111, 23);
            exportXmlButton.TabIndex = 14;
            exportXmlButton.Text = "Экспорт в XML";
            exportXmlButton.UseVisualStyleBackColor = true;
            exportXmlButton.Click += exportXmlButton_Click;
            // 
            // importXmlButton
            // 
            importXmlButton.Location = new Point(584, 217);
            importXmlButton.Name = "importXmlButton";
            importXmlButton.Size = new Size(111, 23);
            importXmlButton.TabIndex = 15;
            importXmlButton.Text = "Импорт из XML";
            importXmlButton.UseVisualStyleBackColor = true;
            importXmlButton.Click += importXmlButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 297);
            Controls.Add(importXmlButton);
            Controls.Add(exportXmlButton);
            Controls.Add(importTxtButton);
            Controls.Add(exportTxtButton);
            Controls.Add(usersListBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анкета пользователей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private ListBox usersListBox;
        private Button exportTxtButton;
        private Button importTxtButton;
        private Button exportXmlButton;
        private Button importXmlButton;
    }
}
