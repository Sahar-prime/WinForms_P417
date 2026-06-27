namespace H_W_8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gbFuel = new GroupBox();
            txtFuelPrice = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbFuelTotal = new GroupBox();
            lblFuelTotalUnit = new Label();
            lblFuelTotal = new Label();
            txtFuelSum = new TextBox();
            txtFuelQuantity = new TextBox();
            rbSum = new RadioButton();
            rbQuantity = new RadioButton();
            cmbFuel = new ComboBox();
            gbCafe = new GroupBox();
            gbCafeTotal = new GroupBox();
            label4 = new Label();
            lblCafeTotal = new Label();
            txtCountFries = new TextBox();
            txtCountBurger = new TextBox();
            txtCountCola = new TextBox();
            txtCountHotDog = new TextBox();
            txtPriceBurger = new TextBox();
            txtPriceFries = new TextBox();
            txtPriceCola = new TextBox();
            txtPriceHotDog = new TextBox();
            chkBurger = new CheckBox();
            chkFries = new CheckBox();
            chkCola = new CheckBox();
            chkHotDog = new CheckBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            lblGrandTotal = new Label();
            btnCalculate = new Button();
            clearTimer = new System.Windows.Forms.Timer(components);
            gbFuel.SuspendLayout();
            gbFuelTotal.SuspendLayout();
            gbCafe.SuspendLayout();
            gbCafeTotal.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gbFuel
            // 
            gbFuel.Controls.Add(txtFuelPrice);
            gbFuel.Controls.Add(label2);
            gbFuel.Controls.Add(label1);
            gbFuel.Controls.Add(gbFuelTotal);
            gbFuel.Controls.Add(txtFuelSum);
            gbFuel.Controls.Add(txtFuelQuantity);
            gbFuel.Controls.Add(rbSum);
            gbFuel.Controls.Add(rbQuantity);
            gbFuel.Controls.Add(cmbFuel);
            gbFuel.Location = new Point(12, 12);
            gbFuel.Name = "gbFuel";
            gbFuel.Size = new Size(333, 278);
            gbFuel.TabIndex = 0;
            gbFuel.TabStop = false;
            gbFuel.Text = "Автозаправка";
            // 
            // txtFuelPrice
            // 
            txtFuelPrice.Location = new Point(176, 48);
            txtFuelPrice.Name = "txtFuelPrice";
            txtFuelPrice.ReadOnly = true;
            txtFuelPrice.Size = new Size(121, 23);
            txtFuelPrice.TabIndex = 9;
            txtFuelPrice.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 56);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Бензин";
            // 
            // gbFuelTotal
            // 
            gbFuelTotal.Controls.Add(lblFuelTotalUnit);
            gbFuelTotal.Controls.Add(lblFuelTotal);
            gbFuelTotal.Location = new Point(22, 155);
            gbFuelTotal.Name = "gbFuelTotal";
            gbFuelTotal.Size = new Size(275, 117);
            gbFuelTotal.TabIndex = 6;
            gbFuelTotal.TabStop = false;
            gbFuelTotal.Text = "На оплату";
            // 
            // lblFuelTotalUnit
            // 
            lblFuelTotalUnit.AutoSize = true;
            lblFuelTotalUnit.Location = new Point(239, 87);
            lblFuelTotalUnit.Name = "lblFuelTotalUnit";
            lblFuelTotalUnit.Size = new Size(30, 15);
            lblFuelTotalUnit.TabIndex = 1;
            lblFuelTotalUnit.Text = "руб.";
            // 
            // lblFuelTotal
            // 
            lblFuelTotal.AutoSize = true;
            lblFuelTotal.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFuelTotal.Location = new Point(62, 31);
            lblFuelTotal.Name = "lblFuelTotal";
            lblFuelTotal.Size = new Size(42, 50);
            lblFuelTotal.TabIndex = 0;
            lblFuelTotal.Text = "0";
            // 
            // txtFuelSum
            // 
            txtFuelSum.Enabled = false;
            txtFuelSum.Location = new Point(176, 110);
            txtFuelSum.Name = "txtFuelSum";
            txtFuelSum.Size = new Size(100, 23);
            txtFuelSum.TabIndex = 5;
            // 
            // txtFuelQuantity
            // 
            txtFuelQuantity.Location = new Point(176, 81);
            txtFuelQuantity.Name = "txtFuelQuantity";
            txtFuelQuantity.Size = new Size(100, 23);
            txtFuelQuantity.TabIndex = 4;
            // 
            // rbSum
            // 
            rbSum.AutoSize = true;
            rbSum.Location = new Point(22, 106);
            rbSum.Name = "rbSum";
            rbSum.Size = new Size(63, 19);
            rbSum.TabIndex = 3;
            rbSum.Text = "Сумма";
            rbSum.UseVisualStyleBackColor = true;
            rbSum.CheckedChanged += rbSum_CheckedChanged;
            // 
            // rbQuantity
            // 
            rbQuantity.AutoSize = true;
            rbQuantity.Checked = true;
            rbQuantity.Location = new Point(22, 81);
            rbQuantity.Name = "rbQuantity";
            rbQuantity.Size = new Size(90, 19);
            rbQuantity.TabIndex = 2;
            rbQuantity.TabStop = true;
            rbQuantity.Text = "Количество";
            rbQuantity.UseVisualStyleBackColor = true;
            rbQuantity.CheckedChanged += rbQuantity_CheckedChanged;
            // 
            // cmbFuel
            // 
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(176, 22);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(121, 23);
            cmbFuel.TabIndex = 0;
            cmbFuel.SelectedIndexChanged += cmbFuel_SelectedIndexChanged;
            // 
            // gbCafe
            // 
            gbCafe.Controls.Add(gbCafeTotal);
            gbCafe.Controls.Add(txtCountFries);
            gbCafe.Controls.Add(txtCountBurger);
            gbCafe.Controls.Add(txtCountCola);
            gbCafe.Controls.Add(txtCountHotDog);
            gbCafe.Controls.Add(txtPriceBurger);
            gbCafe.Controls.Add(txtPriceFries);
            gbCafe.Controls.Add(txtPriceCola);
            gbCafe.Controls.Add(txtPriceHotDog);
            gbCafe.Controls.Add(chkBurger);
            gbCafe.Controls.Add(chkFries);
            gbCafe.Controls.Add(chkCola);
            gbCafe.Controls.Add(chkHotDog);
            gbCafe.Location = new Point(400, 12);
            gbCafe.Name = "gbCafe";
            gbCafe.Size = new Size(325, 278);
            gbCafe.TabIndex = 1;
            gbCafe.TabStop = false;
            gbCafe.Text = "Мини-кафе";
            // 
            // gbCafeTotal
            // 
            gbCafeTotal.Controls.Add(label4);
            gbCafeTotal.Controls.Add(lblCafeTotal);
            gbCafeTotal.Location = new Point(30, 155);
            gbCafeTotal.Name = "gbCafeTotal";
            gbCafeTotal.Size = new Size(275, 117);
            gbCafeTotal.TabIndex = 11;
            gbCafeTotal.TabStop = false;
            gbCafeTotal.Text = "На оплату";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 87);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 1;
            label4.Text = "руб.";
            // 
            // lblCafeTotal
            // 
            lblCafeTotal.AutoSize = true;
            lblCafeTotal.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCafeTotal.Location = new Point(65, 31);
            lblCafeTotal.Name = "lblCafeTotal";
            lblCafeTotal.Size = new Size(42, 50);
            lblCafeTotal.TabIndex = 0;
            lblCafeTotal.Text = "0";
            // 
            // txtCountFries
            // 
            txtCountFries.Enabled = false;
            txtCountFries.Location = new Point(217, 73);
            txtCountFries.Name = "txtCountFries";
            txtCountFries.Size = new Size(71, 23);
            txtCountFries.TabIndex = 9;
            // 
            // txtCountBurger
            // 
            txtCountBurger.Enabled = false;
            txtCountBurger.Location = new Point(217, 48);
            txtCountBurger.Name = "txtCountBurger";
            txtCountBurger.Size = new Size(71, 23);
            txtCountBurger.TabIndex = 10;
            // 
            // txtCountCola
            // 
            txtCountCola.Enabled = false;
            txtCountCola.Location = new Point(217, 98);
            txtCountCola.Name = "txtCountCola";
            txtCountCola.Size = new Size(71, 23);
            txtCountCola.TabIndex = 9;
            // 
            // txtCountHotDog
            // 
            txtCountHotDog.Enabled = false;
            txtCountHotDog.Location = new Point(217, 23);
            txtCountHotDog.Name = "txtCountHotDog";
            txtCountHotDog.Size = new Size(71, 23);
            txtCountHotDog.TabIndex = 8;
            // 
            // txtPriceBurger
            // 
            txtPriceBurger.Location = new Point(138, 48);
            txtPriceBurger.Name = "txtPriceBurger";
            txtPriceBurger.ReadOnly = true;
            txtPriceBurger.Size = new Size(73, 23);
            txtPriceBurger.TabIndex = 7;
            txtPriceBurger.Text = "59";
            // 
            // txtPriceFries
            // 
            txtPriceFries.Location = new Point(138, 73);
            txtPriceFries.Name = "txtPriceFries";
            txtPriceFries.ReadOnly = true;
            txtPriceFries.Size = new Size(73, 23);
            txtPriceFries.TabIndex = 6;
            txtPriceFries.Text = "53";
            // 
            // txtPriceCola
            // 
            txtPriceCola.Location = new Point(138, 98);
            txtPriceCola.Name = "txtPriceCola";
            txtPriceCola.ReadOnly = true;
            txtPriceCola.Size = new Size(73, 23);
            txtPriceCola.TabIndex = 5;
            txtPriceCola.Text = "75";
            // 
            // txtPriceHotDog
            // 
            txtPriceHotDog.Location = new Point(138, 23);
            txtPriceHotDog.Name = "txtPriceHotDog";
            txtPriceHotDog.ReadOnly = true;
            txtPriceHotDog.Size = new Size(73, 23);
            txtPriceHotDog.TabIndex = 4;
            txtPriceHotDog.Text = "45";
            // 
            // chkBurger
            // 
            chkBurger.AutoSize = true;
            chkBurger.Location = new Point(30, 48);
            chkBurger.Name = "chkBurger";
            chkBurger.Size = new Size(85, 19);
            chkBurger.TabIndex = 3;
            chkBurger.Text = "Гамбургер";
            chkBurger.UseVisualStyleBackColor = true;
            chkBurger.CheckedChanged += chkFood_CheckedChanged;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Location = new Point(30, 73);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(49, 19);
            chkFries.TabIndex = 2;
            chkFries.Text = "Фри";
            chkFries.UseVisualStyleBackColor = true;
            chkFries.CheckedChanged += chkFood_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(30, 98);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(53, 19);
            chkCola.TabIndex = 1;
            chkCola.Text = "Кола";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkFood_CheckedChanged;
            // 
            // chkHotDog
            // 
            chkHotDog.AutoSize = true;
            chkHotDog.Location = new Point(30, 25);
            chkHotDog.Name = "chkHotDog";
            chkHotDog.Size = new Size(68, 19);
            chkHotDog.TabIndex = 0;
            chkHotDog.Text = "Хот-дог";
            chkHotDog.UseVisualStyleBackColor = true;
            chkHotDog.CheckedChanged += chkFood_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lblGrandTotal);
            groupBox3.Controls.Add(btnCalculate);
            groupBox3.Location = new Point(152, 296);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 129);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "К оплате";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 106);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "руб.";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGrandTotal.Location = new Point(167, 28);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(54, 65);
            lblGrandTotal.TabIndex = 1;
            lblGrandTotal.Text = "0";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(23, 46);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 47);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Оплатить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // clearTimer
            // 
            clearTimer.Interval = 10000;
            clearTimer.Tick += clearTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 437);
            Controls.Add(groupBox3);
            Controls.Add(gbCafe);
            Controls.Add(gbFuel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Авто-касса";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            gbFuel.ResumeLayout(false);
            gbFuel.PerformLayout();
            gbFuelTotal.ResumeLayout(false);
            gbFuelTotal.PerformLayout();
            gbCafe.ResumeLayout(false);
            gbCafe.PerformLayout();
            gbCafeTotal.ResumeLayout(false);
            gbCafeTotal.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox gbFuel;
        private GroupBox gbCafe;
        private GroupBox groupBox3;
        private ComboBox cmbFuel;
        private RadioButton rbSum;
        private RadioButton rbQuantity;
        private TextBox txtPriceCola;
        private TextBox txtFuelQuantity;
        private TextBox txtFuelSum;
        private GroupBox gbFuelTotal;
        private Label label2;
        private Label label1;
        private TextBox txtFuelPrice;
        private Label lblFuelTotal;
        private Label lblFuelTotalUnit;
        private CheckBox chkBurger;
        private CheckBox chkFries;
        private CheckBox chkCola;
        private CheckBox chkHotDog;
        private TextBox txtPriceBurger;
        private TextBox txtPriceFries;
        private TextBox txtPriceHotDog;
        private TextBox txtCountFries;
        private TextBox txtCountBurger;
        private TextBox txtCountCola;
        private TextBox txtCountHotDog;
        private Button btnCalculate;
        private Label lblGrandTotal;
        private Label label3;
        private System.Windows.Forms.Timer clearTimer;
        private GroupBox gbCafeTotal;
        private Label label4;
        private Label lblCafeTotal;
    }
}