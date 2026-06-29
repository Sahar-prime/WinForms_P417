namespace Test
{
    partial class MainForm
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
            btn_add = new Button();
            btn_red = new Button();
            btn_del = new Button();
            btn_clear = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_add.Location = new Point(12, 293);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(481, 24);
            btn_add.TabIndex = 0;
            btn_add.Text = "Добавить товар";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_red
            // 
            btn_red.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_red.Location = new Point(12, 323);
            btn_red.Name = "btn_red";
            btn_red.Size = new Size(481, 24);
            btn_red.TabIndex = 1;
            btn_red.Text = "Редактировать товар";
            btn_red.UseVisualStyleBackColor = true;
            btn_red.Click += btn_red_Click;
            // 
            // btn_del
            // 
            btn_del.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_del.Location = new Point(12, 353);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(481, 24);
            btn_del.TabIndex = 2;
            btn_del.Text = "Удалить товар";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_clear
            // 
            btn_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_clear.Location = new Point(12, 383);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(481, 24);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Очистить список";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(481, 259);
            listBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 419);
            Controls.Add(listBox1);
            Controls.Add(btn_clear);
            Controls.Add(btn_del);
            Controls.Add(btn_red);
            Controls.Add(btn_add);
            Name = "MainForm";
            Text = "Каталог товаров";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add;
        private Button btn_red;
        private Button btn_del;
        private Button btn_clear;
        private ListBox listBox1;
    }
}
