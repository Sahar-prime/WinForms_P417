using System.Globalization;

namespace H_W_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text.Trim();

            string[] formats = { "dd.MM.yyyy", "dd/MM/yyyy", "dd-MM-yyyy" };

            // Проверяем и парсим введенную дату
            if (!DateTime.TryParseExact(text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime targetDate))
            {
                resultTextBox.Text = "";
                MessageBox.Show("Неверный формат даты! Используйте шаблон ДД.ММ.ГГГГ (например: 31.12.2026).",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            targetDate = targetDate.Date.AddDays(1).AddSeconds(-1);

            DateTime now = DateTime.Now;

            // Проверяем, что дата действительно находится в будущем
            if (targetDate <= now)
            {
                resultTextBox.Text = "";
                MessageBox.Show("Введенная дата уже наступила или прошла! Укажите дату в будущем.",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Вычисляем чистую разницу во времени
            TimeSpan difference = targetDate - now;
            double totalDays = difference.TotalDays;

            if (rbYears.Checked)
            {
                // В году в среднем 365.25 дней с учетом високосных
                double years = totalDays / 365.25;
                resultTextBox.Text = $"{years:F3} лет"; // F3 — три знака после запятой
            }
            else if (rbMonths.Checked)
            {
                // В месяце в среднем 30.437 дней
                double months = totalDays / 30.437;
                resultTextBox.Text = $"{months:F2} месяцев"; // F2 — два знака после запятой
            }
            else if (rbDays.Checked)
            {
                resultTextBox.Text = $"{Math.Round(totalDays)} дней";
            }
            else if (rbMinutes.Checked)
            {
                resultTextBox.Text = $"{(long)difference.TotalMinutes} минут";
            }
            else if (rbSeconds.Checked)
            {
                resultTextBox.Text = $"{(long)difference.TotalSeconds} секунд";
            }
            else
            {
                resultTextBox.Text = "Выберите вариант расчета";
            }
        }
    }
}