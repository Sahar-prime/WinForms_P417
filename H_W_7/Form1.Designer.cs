namespace H_W_7
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
            inputTextBox = new TextBox();
            calculateButton = new Button();
            rbYears = new RadioButton();
            rbMonths = new RadioButton();
            rbDays = new RadioButton();
            rbMinutes = new RadioButton();
            rbSeconds = new RadioButton();
            resultTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(110, 27);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(54, 56);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(219, 29);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Рассчитать оставшееся время";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // rbYears
            // 
            rbYears.AutoSize = true;
            rbYears.Location = new Point(125, 91);
            rbYears.Name = "rbYears";
            rbYears.Size = new Size(65, 19);
            rbYears.TabIndex = 2;
            rbYears.Text = "В годах";
            rbYears.UseVisualStyleBackColor = true;
            // 
            // rbMonths
            // 
            rbMonths.AutoSize = true;
            rbMonths.Location = new Point(125, 116);
            rbMonths.Name = "rbMonths";
            rbMonths.Size = new Size(81, 19);
            rbMonths.TabIndex = 3;
            rbMonths.Text = "В месяцах";
            rbMonths.UseVisualStyleBackColor = true;
            // 
            // rbDays
            // 
            rbDays.AutoSize = true;
            rbDays.Location = new Point(125, 141);
            rbDays.Name = "rbDays";
            rbDays.Size = new Size(60, 19);
            rbDays.TabIndex = 4;
            rbDays.Text = "В днях";
            rbDays.UseVisualStyleBackColor = true;
            // 
            // rbMinutes
            // 
            rbMinutes.AutoSize = true;
            rbMinutes.Location = new Point(125, 166);
            rbMinutes.Name = "rbMinutes";
            rbMinutes.Size = new Size(81, 19);
            rbMinutes.TabIndex = 5;
            rbMinutes.Text = "В минутах";
            rbMinutes.UseVisualStyleBackColor = true;
            // 
            // rbSeconds
            // 
            rbSeconds.AutoSize = true;
            rbSeconds.Location = new Point(125, 191);
            rbSeconds.Name = "rbSeconds";
            rbSeconds.Size = new Size(84, 19);
            rbSeconds.TabIndex = 6;
            rbSeconds.Text = "В секундах";
            rbSeconds.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(54, 253);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(219, 23);
            resultTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 15);
            label1.TabIndex = 8;
            label1.Text = "Укажите дату в будущем для примера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 235);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Ответ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 302);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultTextBox);
            Controls.Add(rbSeconds);
            Controls.Add(rbMinutes);
            Controls.Add(rbDays);
            Controls.Add(rbMonths);
            Controls.Add(rbYears);
            Controls.Add(calculateButton);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button calculateButton;
        private RadioButton rbYears;
        private RadioButton rbMonths;
        private RadioButton rbDays;
        private RadioButton rbMinutes;
        private RadioButton rbSeconds;
        private TextBox resultTextBox;
        private Label label1;
        private Label label2;
    }
}