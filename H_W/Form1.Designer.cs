namespace H_W
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
            INFO = new Button();
            SuspendLayout();
            // 
            // INFO
            // 
            INFO.Location = new Point(285, 264);
            INFO.Name = "INFO";
            INFO.Size = new Size(203, 69);
            INFO.TabIndex = 0;
            INFO.Text = "Кликните!";
            INFO.UseVisualStyleBackColor = true;
            INFO.Click += INFO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(INFO);
            Name = "Form1";
            Text = "Моё резюме";
            ResumeLayout(false);
        }

        #endregion

        private Button INFO;
    }
}