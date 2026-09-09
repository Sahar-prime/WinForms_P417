namespace P417_POCO
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
            textBox1 = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            buttonAddCharacter = new Button();
            textBoxNewCharacterName = new TextBox();
            textBoxNewCharacterAge = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(110, 45);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 41);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(110, 45);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(12, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 5;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(511, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 450);
            listBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(288, 9);
            label3.Name = "label3";
            label3.Size = new Size(110, 45);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // buttonAddCharacter
            // 
            buttonAddCharacter.Location = new Point(299, 337);
            buttonAddCharacter.Name = "buttonAddCharacter";
            buttonAddCharacter.Size = new Size(75, 23);
            buttonAddCharacter.TabIndex = 8;
            buttonAddCharacter.Text = "Добавить";
            buttonAddCharacter.UseVisualStyleBackColor = true;
            buttonAddCharacter.Click += buttonAddCharacter_Click;
            // 
            // textBoxNewCharacterName
            // 
            textBoxNewCharacterName.Location = new Point(288, 279);
            textBoxNewCharacterName.Name = "textBoxNewCharacterName";
            textBoxNewCharacterName.Size = new Size(100, 23);
            textBoxNewCharacterName.TabIndex = 9;
            // 
            // textBoxNewCharacterAge
            // 
            textBoxNewCharacterAge.Location = new Point(288, 308);
            textBoxNewCharacterAge.Name = "textBoxNewCharacterAge";
            textBoxNewCharacterAge.Size = new Size(100, 23);
            textBoxNewCharacterAge.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 282);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 11;
            label4.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 311);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "Возраст";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxNewCharacterAge);
            Controls.Add(textBoxNewCharacterName);
            Controls.Add(buttonAddCharacter);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox2;
        private Button buttonAddCharacter;
        private TextBox textBoxNewCharacterName;
        private TextBox textBoxNewCharacterAge;
        private Label label4;
        private Label label5;
    }
}
