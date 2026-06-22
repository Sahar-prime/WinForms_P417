namespace WinForms_P417
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
            clickPlus = new Button();
            textBox1 = new TextBox();
            start_btn = new Button();
            stop_btn = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // clickPlus
            // 
            clickPlus.Location = new Point(12, 84);
            clickPlus.Name = "clickPlus";
            clickPlus.Size = new Size(105, 41);
            clickPlus.TabIndex = 0;
            clickPlus.Text = "КЛИКНИ!";
            clickPlus.UseVisualStyleBackColor = true;
            clickPlus.Click += clickPlus_Click;
            clickPlus.MouseMove += clickPlus_MouseMove;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(105, 64);
            textBox1.TabIndex = 1;
            // 
            // start_btn
            // 
            start_btn.Location = new Point(210, 80);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(75, 23);
            start_btn.TabIndex = 2;
            start_btn.Text = "Старт";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // stop_btn
            // 
            stop_btn.Location = new Point(323, 80);
            stop_btn.Name = "stop_btn";
            stop_btn.Size = new Size(75, 23);
            stop_btn.TabIndex = 3;
            stop_btn.Text = "Стоп";
            stop_btn.UseVisualStyleBackColor = true;
            stop_btn.Click += stop_btn_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(323, 40);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 42);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 5;
            label1.Text = "Количество секунд";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(413, 39);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(33, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(677, 377);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(179, 132);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(281, 22);
            progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(stop_btn);
            Controls.Add(start_btn);
            Controls.Add(textBox1);
            Controls.Add(clickPlus);
            Name = "Form1";
            Text = "Моя программа";
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickPlus;
        private TextBox textBox1;
        private Button start_btn;
        private Button stop_btn;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private ProgressBar progressBar1;
    }
}