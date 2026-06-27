namespace H_W_6
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
            label1 = new Label();
            inputTextBox = new TextBox();
            checkButton = new Button();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 23);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите дату (ДД.ММ.ГГГГ):";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(107, 58);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 1;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(78, 87);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(161, 23);
            checkButton.TabIndex = 2;
            checkButton.Text = "Узнать день недели";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(107, 132);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(100, 23);
            resultTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 181);
            Controls.Add(resultTextBox);
            Controls.Add(checkButton);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private TextBox resultTextBox;
        private Button checkButton;
    }
}