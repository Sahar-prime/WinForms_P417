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

    }
}