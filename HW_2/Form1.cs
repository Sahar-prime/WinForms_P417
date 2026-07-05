using System.Xml.Serialization;

namespace HW_2
{
    public partial class Form1 : Form
    {
        // Список для хранения всех пользователей.
        private List<User> users = new List<User>();

        // Индекс выбранного пользователя в ListBox (для редактирования/удаления).
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // ОБРАБОТЧИКИ СОБЫТИЙ
        private void addButton_Click(object sender, EventArgs e)
        {
            // Проверка, что поля "Имя" и "Фамилия" заполнены.
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поля 'Имя' и 'Фамилия'.");
                return;
            }

            // Создаём нового пользователя с данными из текстовых полей.
            User newUser = new User
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text
            };

            // Добавляем пользователя в список.
            users.Add(newUser);

            // Обновляем ListBox, чтобы отобразить нового пользователя.
            UpdateListBox();

            // Очищаем поля ввода для нового пользователя.
            ClearFields();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли пользователь для редактирования.
            if (selectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для редактирования.");
                return;
            }

            // Проверяем, что поля "Имя" и "Фамилия" заполнены.
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поля 'Имя' и 'Фамилия'.");
                return;
            }

            // Обновляем данные выбранного пользователя.
            users[selectedIndex].FirstName = firstNameTextBox.Text;
            users[selectedIndex].LastName = lastNameTextBox.Text;
            users[selectedIndex].Email = emailTextBox.Text;
            users[selectedIndex].Phone = phoneTextBox.Text;

            // Обновляем ListBox и очищаем поля ввода.
            UpdateListBox();
            ClearFields();
            selectedIndex = -1; // Сбрасываем выбранный индекс.
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли пользователь для удаления.
            if (selectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
                return;
            }

            // Удаляем пользователя из списка.
            users.RemoveAt(selectedIndex);

            // Обновляем ListBox и очищаем поля ввода.
            UpdateListBox();
            ClearFields();
            selectedIndex = -1; // Сбрасываем выбранный индекс.
        }

        // Событие при выборе пользователя в ListBox:
        // загружает данные выбранного пользователя в текстовые поля для редактирования.
        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = usersListBox.SelectedIndex;
            if (selectedIndex == -1) return; // Если ничего не выбрано, выходим.

            // Получаем выбранного пользователя и заполняем текстовые поля его данными.
            User selectedUser = users[selectedIndex];
            firstNameTextBox.Text = selectedUser.FirstName;
            lastNameTextBox.Text = selectedUser.LastName;
            emailTextBox.Text = selectedUser.Email;
            phoneTextBox.Text = selectedUser.Phone;
        }

        // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ
        // Обновляет содержимое ListBox, отображая всех пользователей.
        private void UpdateListBox()
        {
            usersListBox.Items.Clear();
            foreach (User user in users)
            {
                usersListBox.Items.Add(
                    $"{user.LastName} {user.FirstName} | Email: {user.Email} | Телефон: {user.Phone}");
            }
        }
        private void ClearFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
        }

        // ЭКСПОРТ/ИМПОРТ В TXT
        private void exportTxtButton_Click(object sender, EventArgs e)
        {
            // Открываем диалог сохранения файла.
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt" // Фильтр для текстовых файлов.
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Записываем каждого пользователя в файл в формате CSV.
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (User user in users)
                    {
                        writer.WriteLine(
                            $"{user.LastName},{user.FirstName},{user.Email},{user.Phone}");
                    }
                }
                MessageBox.Show("Данные экспортированы в текстовый файл.");
            }
        }
        private void importTxtButton_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла.
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt" // Фильтр для текстовых файлов.
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                users.Clear(); // Очищаем текущий список пользователей.

                // Читаем файл построчно и добавляем пользователей в список.
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4) // Проверяем, что строка содержит 4 части.
                        {
                            users.Add(new User
                            {
                                LastName = parts[0],
                                FirstName = parts[1],
                                Email = parts[2],
                                Phone = parts[3]
                            });
                        }
                    }
                }

                UpdateListBox(); // Обновляем ListBox.
                MessageBox.Show("Данные импортированы из текстового файла.");
            }
        }

        // ЭКСПОРТ/ИМПОРТ В XML
        private void exportXmlButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml" // Фильтр для XML-файлов.
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сериализуем список пользователей в XML.
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    serializer.Serialize(writer, users);
                }
                MessageBox.Show("Данные экспортированы в XML файл.");
            }
        }
        private void importXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml" // Фильтр для XML-файлов.
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Десериализуем список пользователей из XML.
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    users = (List<User>)serializer.Deserialize(reader);
                }

                UpdateListBox(); // Обновляем ListBox.
                MessageBox.Show("Данные импортированы из XML файла.");
            }
        }
    }

    // Класс для хранения данных о пользователе.
    // [Serializable] позволяет сериализовать объект в XML (для экспорта/импорта).
    [Serializable]
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}