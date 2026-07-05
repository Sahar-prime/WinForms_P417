namespace HW
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
            btnReadFile = new Button();
            progressBar1 = new ProgressBar();
            txtFilePath = new TextBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(125, 58);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(118, 23);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Читать файл";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(92, 103);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(179, 23);
            progressBar1.TabIndex = 1;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(125, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(118, 23);
            txtFilePath.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(83, 129);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 205);
            Controls.Add(txtFilePath);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnReadFile);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Счётчик символов в файле (1-100)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadFile;
        private ProgressBar progressBar1;
        private TextBox txtFilePath;
        private Label lblStatus;
    }
}
