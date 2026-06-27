namespace H_W_4
{
    public partial class Form1 : Form
    {
        private Point startPoint; // Хранит координаты (X, Y) точки, где пользователь зажал левую кнопку мыши
        private int staticCounter = 1;
        private bool isDrawing = false; // Флаг, что пользователь именно рисует

        public Form1()
        {
            InitializeComponent();

            // Включаем правильную обработку стилей мыши для формы
            // Она заставляет форму правильно и без задержек распознавать двойные клики.
            this.SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true; // Запоминаем, что мы начали рисовать
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Если мышь отпущена, но флаг рисования не активен (например, при двойном клике) — ничего не делаем
            if (!isDrawing || e.Button != MouseButtons.Left) return;

            isDrawing = false; // Сбрасываем флаг

            Point endPoint = e.Location;
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);

            // Защита от микро-кликов (двойных кликов), которые система считает за рисование
            if (width < 10 || height < 10)
            {
                // Не показываем ошибку, если это был просто случайный клик/двойной клик на месте
                if (width > 1 || height > 1)
                {
                    MessageBox.Show("Минимальный размер элемента должен быть 10х10 пикселей!",
                                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            // Создаем статик
            Label newStatic = new Label
            {
                Text = staticCounter.ToString(),
                Location = new Point(x, y),
                Size = new Size(width, height),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Tag = staticCounter
            };

            newStatic.MouseClick += Static_MouseClick;
            newStatic.MouseDoubleClick += Static_MouseDoubleClick;

            this.Controls.Add(newStatic);
            newStatic.BringToFront(); //Вытаскиваем статик на передний план

            // Номер увеличивается ТОЛЬКО здесь, когда элемент 100% создан
            staticCounter++;
        }

        private void Static_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Перевод координат 
                Point clickedPointOnForm = this.PointToClient((sender as Control).
                    PointToScreen(e.Location));

                Label targetStatic = null; // Сюда сохраним найденный элемент
                int maxOrder = -1;  // Переменная для поиска максимума

                // ЦИКЛ ПО ВСЕМ ЭЛЕМЕНТАМ НА ФОРМЕ
                foreach (Control control in this.Controls)
                {
                    // Проверяем: это Label? И входит ли точка клика в его границы (квадрат)?
                    if (control is Label && control.Bounds.Contains(clickedPointOnForm))
                    {
                        // Достаем порядковый номер из Tag
                        int currentOrder = (int)control.Tag;
                        if (currentOrder > maxOrder)
                        {
                            maxOrder = currentOrder;
                            targetStatic = (Label)control;
                        }
                    }
                }

                // АЛГОРИТМ ПОИСКА МАКСИМУМА:
                // Если номер текущего статика больше, чем тот, что мы находили ранее
                if (targetStatic != null)
                {
                    int area = targetStatic.Width * targetStatic.Height; // Запоминаем новый максимальный номер
                    this.Text = $"Номер: {targetStatic.Tag} | Площадь: {area} кв.пх | Координаты: X={targetStatic.Left}, Y={targetStatic.Top}"; // Запоминаем сам элемент
                }
            }
        }

        // Работает точно также, только делает поиск минимального номера и его удаляет
        private void Static_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point clickedPointOnForm = this.PointToClient((sender as Control).PointToScreen(e.Location));
                Label targetStatic = null;
                int minOrder = int.MaxValue;

                foreach (Control control in this.Controls)
                {
                    if (control is Label && control.Bounds.Contains(clickedPointOnForm))
                    {
                        int currentOrder = (int)control.Tag;
                        if (currentOrder < minOrder)
                        {
                            minOrder = currentOrder;
                            targetStatic = (Label)control;
                        }
                    }
                }

                if (targetStatic != null)
                {
                    this.Controls.Remove(targetStatic);
                    targetStatic.Dispose();
                }
            }
        }
    }
}