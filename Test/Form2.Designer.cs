namespace Test
{
    partial class DopForm
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
            TB_Made = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_ok = new Button();
            btn_cancel = new Button();
            NUD_Price = new NumericUpDown();
            TB_Name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NUD_Price).BeginInit();
            SuspendLayout();
            // 
            // TB_Made
            // 
            TB_Made.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_Made.Location = new Point(12, 108);
            TB_Made.Name = "TB_Made";
            TB_Made.Size = new Size(259, 23);
            TB_Made.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 4;
            label2.Text = "Страна производитель";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Стоимость";
            // 
            // btn_ok
            // 
            btn_ok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_ok.Location = new Point(12, 245);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 6;
            btn_ok.Text = "Ок";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cancel.Location = new Point(196, 245);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // NUD_Price
            // 
            NUD_Price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NUD_Price.Location = new Point(12, 192);
            NUD_Price.Name = "NUD_Price";
            NUD_Price.Size = new Size(259, 23);
            NUD_Price.TabIndex = 8;
            // 
            // TB_Name
            // 
            TB_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_Name.Location = new Point(12, 27);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(259, 23);
            TB_Name.TabIndex = 9;
            // 
            // DopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 296);
            Controls.Add(TB_Name);
            Controls.Add(NUD_Price);
            Controls.Add(btn_cancel);
            Controls.Add(btn_ok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_Made);
            Name = "DopForm";
            Text = "Карточка товара";
            ((System.ComponentModel.ISupportInitialize)NUD_Price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox TB_Made;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_ok;
        private Button btn_cancel;
        private NumericUpDown NUD_Price;
        private TextBox TB_Name;
    }
}