using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms_P417
{
    partial class Child
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
            textBox1 = new TextBox();
            btnClose = new Button();
            btnOk = new Button();
            btnConst = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 98);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(181, 127);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(69, 127);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnConst
            // 
            btnConst.Location = new Point(125, 156);
            btnConst.Name = "btnConst";
            btnConst.Size = new Size(75, 23);
            btnConst.TabIndex = 3;
            btnConst.Text = "const";
            btnConst.UseVisualStyleBackColor = true;
            btnConst.Click += btnConst_Click;
            // 
            // Child
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 300);
            Controls.Add(btnConst);
            Controls.Add(btnOk);
            Controls.Add(btnClose);
            Controls.Add(textBox1);
            Name = "Child";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnClose;
        private Button btnOk;
        private Button btnConst;
    }
}