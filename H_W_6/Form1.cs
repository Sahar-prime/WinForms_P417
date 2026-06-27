using System.Globalization;

namespace H_W_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string text = inputTextBox.Text.Trim();
            string[] formats = { "dd.MM.yyyy", "dd/MM/yyyy", "dd-MM-yyyy" };

            if (DateTime.TryParseExact(text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                CultureInfo russianCulture = new CultureInfo("ru-RU");
                string dayName = parsedDate.ToString("dddd", russianCulture);
                dayName = char.ToUpper(dayName[0]) + dayName.Substring(1);
                resultTextBox.Text = dayName;
            }
            else
            {
                resultTextBox.Text = "";
                MessageBox.Show("Неверный формат даты! Используйте шаблон ДД.ММ.ГГГГ (например: 24.06.2026).",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}