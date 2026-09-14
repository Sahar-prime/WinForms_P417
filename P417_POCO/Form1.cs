using System.Text.Json;

namespace P417_POCO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Person person = new Person { Name = "Tom", Age = 25 };

            label1.DataBindings.Add(new Binding("Text", person, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.DataBindings.Add(new Binding("Text", person, "Name", false, DataSourceUpdateMode.OnPropertyChanged));

            //Binding binding = new Binding("Text", person, "Name");
            //binding.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            //textBox1.DataBindings.Add(binding);

            label2.DataBindings.Add(new Binding("Text", person, "Age", false, DataSourceUpdateMode.OnPropertyChanged));
            numericUpDown1.DataBindings.Add(new Binding("Value", person, "Age", false, DataSourceUpdateMode.OnPropertyChanged));

            button1.Click += (o, e) => person.Name = "Admin";

            //////////////////////////////////////////////////////
            this.DataContext = new MainViewModel(); //устанавливаем контекст данных для всей формы
            listBox1.DataBindings.Add(new Binding
                ("DataSource", this.DataContext, "People", false, DataSourceUpdateMode.OnPropertyChanged));

            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            listBox1.DataBindings.Add(new Binding
            ("SelectedValue", this.DataContext, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));

            label3.DataBindings.Add(new Binding
                ("Text", this.DataContext, "SelectedPerson", false, DataSourceUpdateMode.OnPropertyChanged, ""));
            label6.DataBindings.Add(new Binding
                ("Text", this.DataContext, "SelectedPerson.Age", false, DataSourceUpdateMode.OnPropertyChanged, "0"));
        }

        private void buttonAddCharacter_Click(object sender, EventArgs e)
        {
            string name = textBoxNewCharacterName.Text.Trim();

            // Проверяем корректность ввода текста и возраста
            if (!string.IsNullOrEmpty(name) && int.TryParse(textBoxNewCharacterAge.Text.Trim(), out int age))
            {
                if (this.DataContext is MainViewModel viewModel)
                {
                    // Вызываем созданный метод бизнес-логики
                    viewModel.AddCharacter(name, age);
                }

                // Очищаем поля ввода для следующего ввода
                textBoxNewCharacterName.Clear();
                textBoxNewCharacterAge.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректное имя и возраст персонажа!");
            }
        }

        // Экспорт и Импорт данных
        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (this.DataContext is MainViewModel viewModel && viewModel.People != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var options = new JsonSerializerOptions { WriteIndented = true };
                        string jsonString = JsonSerializer.Serialize(
                            viewModel.People,
                            options
                            );

                        File.WriteAllText(saveFileDialog1.FileName, jsonString);
                        MessageBox.Show("Данные успешно экспортированы!",
                            "Успех", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте: {ex.Message}",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (this.DataContext is MainViewModel viewModel)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonString = File.ReadAllText(openFileDialog1.FileName);

                        var importedPeople = JsonSerializer.Deserialize<System.
                            Collections.
                            Generic.
                            List<Person>>(jsonString);

                        if (importedPeople != null)
                        {
                            viewModel.People.Clear();

                            foreach (var person in importedPeople)
                            {
                                viewModel.People.Add(person);
                            }

                            MessageBox.Show("Данные успешно импортированы!", 
                                "Успех",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при импорте: {ex.Message}",
                            "Ошибка",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}