namespace HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Укажите корректный путь к файлу!");
                return;
            }

            lblStatus.Text = "Чтение файла...";
            progressBar1.Value = 0;

            try
            {
                // Получаем общее количество символов в файле
                int totalChars = (int)new FileInfo(filePath).Length;

                // Читаем файл и обновляем ProgressBar
                await ReadFileAsync(filePath, totalChars);
                lblStatus.Text = $"Файл прочитан! Всего символов: {totalChars}";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ошибка: {ex.Message}";
            }
        }

        private async Task ReadFileAsync(string filePath, int totalChars)
        {
            using (var reader = new StreamReader(filePath))
            {
                char[] buffer = new char[1024];
                int charsRead;
                int totalCharsRead = 0;

                while ((charsRead = await reader.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    totalCharsRead += charsRead;
                    progressBar1.Value = totalCharsRead;
                    await Task.Delay(10);
                }
            }
        }
    }
}