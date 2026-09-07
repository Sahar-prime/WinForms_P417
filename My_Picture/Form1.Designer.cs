namespace My_Picture
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
            cmbTools = new ComboBox();
            pictureBox1 = new PictureBox();
            btn_undo = new Button();
            btn_clear = new Button();
            btn_color = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbTools
            // 
            cmbTools.FormattingEnabled = true;
            cmbTools.Location = new Point(12, 12);
            cmbTools.Name = "cmbTools";
            cmbTools.Size = new Size(121, 23);
            cmbTools.TabIndex = 0;
            cmbTools.SelectedIndexChanged += cmbTools_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-2, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 409);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_undo
            // 
            btn_undo.Location = new Point(634, 8);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new Size(78, 27);
            btn_undo.TabIndex = 2;
            btn_undo.Text = "Отменить";
            btn_undo.UseVisualStyleBackColor = true;
            btn_undo.Click += btn_undo_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(718, 8);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(70, 27);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Очистить";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_color
            // 
            btn_color.Location = new Point(139, 12);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(42, 23);
            btn_color.TabIndex = 4;
            btn_color.Text = "Цвет";
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_color);
            Controls.Add(btn_clear);
            Controls.Add(btn_undo);
            Controls.Add(pictureBox1);
            Controls.Add(cmbTools);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbTools;
        private PictureBox pictureBox1;
        private Button btn_undo;
        private Button btn_clear;
        private Button btn_color;
    }
}
