namespace H_W_8
{
    public partial class Form1 : Form
    {
        // Базовые тарифы на топливо
        private double priceA92 = 40.00;
        private double priceA95 = 45.00;
        private double priceDiesel = 48.00;

        // Переменная-накопитель для отчета в конце дня
        private double totalDayRevenue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFuelData();
            InitializeCafePrices();
            ResetForm();
        }

        // Заполнение списка горючего при старте
        private void InitializeFuelData()
        {
            cmbFuel.Items.Clear();
            cmbFuel.Items.Add("АИ-92");
            cmbFuel.Items.Add("АИ-95");
            cmbFuel.Items.Add("ДТ");
            cmbFuel.SelectedIndex = 0; // Автоматический выбор первого элемента
        }

        // Установка цен на товары в кафе
        private void InitializeCafePrices()
        {
            txtPriceHotDog.Text = "45";
            txtPriceBurger.Text = "59";
            txtPriceFries.Text = "53";
            txtPriceCola.Text = "75";
        }

        private void cmbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = 0;
            switch (cmbFuel.SelectedItem.ToString())
            {
                case "АИ-92": price = priceA92; break;
                case "АИ-95": price = priceA95; break;
                case "ДТ": price = priceDiesel; break;
            }
            txtFuelPrice.Text = price.ToString("F2");
            ClearFuelInputs();
        }

        private void rbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQuantity.Checked)
            {
                txtFuelQuantity.Enabled = true;
                txtFuelSum.Enabled = false;
                txtFuelSum.Clear();
                gbFuelTotal.Text = "На оплату";
                lblFuelTotalUnit.Text = "руб.";
            }
        }

        private void rbSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSum.Checked)
            {
                txtFuelSum.Enabled = true;
                txtFuelQuantity.Enabled = false;
                txtFuelQuantity.Clear();
                gbFuelTotal.Text = "К выдаче";
                lblFuelTotalUnit.Text = "л";
            }
        }

        private void chkFood_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk == null) return;

            // Связываем чекбокс с соответствующим полем количества
            TextBox countBox = null;
            if (chk == chkHotDog) countBox = txtCountHotDog;
            if (chk == chkBurger) countBox = txtCountBurger;
            if (chk == chkFries) countBox = txtCountFries;
            if (chk == chkCola) countBox = txtCountCola;

            if (countBox != null)
            {
                countBox.Enabled = chk.Checked;
                if (!chk.Checked) countBox.Clear(); // Сброс текста при снятии галочки
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double fuelPrice = double.Parse(txtFuelPrice.Text);
            double fuelTotalCost = 0; // Сколько стоит топливо в рублях
            double fuelLiters = 0;    // Сколько литров залить

            // 1. Расчет топлива
            if (rbQuantity.Checked)
            {
                if (double.TryParse(txtFuelQuantity.Text, out fuelLiters))
                {
                    fuelTotalCost = fuelLiters * fuelPrice;
                    lblFuelTotal.Text = fuelTotalCost.ToString("F2");
                }
            }
            else if (rbSum.Checked)
            {
                if (double.TryParse(txtFuelSum.Text, out fuelTotalCost))
                {
                    fuelLiters = fuelPrice > 0 ? fuelTotalCost / fuelPrice : 0;
                    lblFuelTotal.Text = fuelLiters.ToString("F2");
                }
            }

            // 2. Расчет кафе
            double cafeTotalCost = 0;
            cafeTotalCost += GetItemSum(chkHotDog, txtPriceHotDog, txtCountHotDog);
            cafeTotalCost += GetItemSum(chkBurger, txtPriceBurger, txtCountBurger);
            cafeTotalCost += GetItemSum(chkFries, txtPriceFries, txtCountFries);
            cafeTotalCost += GetItemSum(chkCola, txtPriceCola, txtCountCola);
            lblCafeTotal.Text = cafeTotalCost.ToString("F2");

            // 3. Расчет финального чека
            double grandTotal = fuelTotalCost + cafeTotalCost;
            lblGrandTotal.Text = grandTotal.ToString("F2");

            // Аккумулируем выручку за рабочую смену
            totalDayRevenue += grandTotal;

            // Перезапуск таймера на автоматическую очистку
            clearTimer.Stop();
            clearTimer.Start();
        }

        // Вспомогательный метод подсчета стоимости конкретного товара
        private double GetItemSum(CheckBox chk, TextBox priceBox, TextBox countBox)
        {
            if (chk.Checked &&
                double.TryParse(priceBox.Text, out double price) &&
                double.TryParse(countBox.Text, out double count))
            {
                return price * count;
            }
            return 0;
        }

        private void ClearFuelInputs()
        {
            txtFuelQuantity.Clear();
            txtFuelSum.Clear();
            lblFuelTotal.Text = "0.00";
        }

        // Срабатывание таймера (прошло 10 секунд после расчета)
        private void clearTimer_Tick(object sender, EventArgs e)
        {
            clearTimer.Stop(); // Временно отключаем таймер, пока открыто окно

            DialogResult result = MessageBox.Show(
                "Очистить форму для обслуживания следующего клиента?",
                "Запрос на очистку",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
            else
            {
                clearTimer.Start(); // Если кассир нажал "Нет", ждем еще 10 секунд
            }
        }

        // Приведение всех изменяемых элементов к исходному состоянию
        private void ResetForm()
        {
            rbQuantity.Checked = true;
            ClearFuelInputs();

            chkHotDog.Checked = false;
            chkBurger.Checked = false;
            chkFries.Checked = false;
            chkCola.Checked = false;

            lblCafeTotal.Text = "0.00";
            lblGrandTotal.Text = "0.00";
        }

        // Перехват закрытия программы (Конец смены)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(
                $"Рабочий день успешно завершен!\nОбщая кассовая выручка за смену: {totalDayRevenue.ToString("F2")} руб.",
                "Финальный отчет",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}