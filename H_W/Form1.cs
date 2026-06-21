namespace H_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void INFO_Click(object sender, EventArgs e)
        {
            string[] resumeParts = {
                "ФИО: Курбанов Сахрутдин Ахмедович",
                "Возраст: 17 лет",
                "Опыт работы: Программист",
                "Навыки: Python, C++, C#"
            };

            int totalChars = 0;
            foreach (var part in resumeParts)
            {
                totalChars += part.Length;
            }

            for (int i = 0; i < resumeParts.Length; i++)
            {
                string title = (i == resumeParts.Length - 1)
                    ? $"Среднее количество символов: {totalChars / resumeParts.Length}"
                    : $"Часть {i + 1}";
                MessageBox.Show(resumeParts[i], title);
            }
        }
    }
}