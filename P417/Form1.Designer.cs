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
            SuspendLayout();
            // 
            // clickPlus
            // 
            clickPlus.Location = new Point(316, 238);
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
            textBox1.Location = new Point(222, 84);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(309, 117);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(clickPlus);
            Name = "Form1";
            Text = "Моя программа";
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickPlus;
        private TextBox textBox1;
    }
}
