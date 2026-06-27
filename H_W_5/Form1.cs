namespace H_W_5
{
    public partial class Form1 : Form
    {
        private Label runawayStatic; // Наш "убегающий статик"
        private Random random = new Random();
        private const int DangerZone = 30; // Дистанция "опасной зоны" в пикселях

        public Form1()
        {
            InitializeComponent();

            // Создаем убегающий статик
            runawayStatic = new Label
            {
                Text = "Статик",
                Size = new Size(80, 30),
                BackColor = Color.Crimson,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                // Начальная позиция строго по центру формы
                Location = new Point((this.ClientSize.Width - 80) / 2, (this.ClientSize.Height - 30) / 2)
            };

            // Добавляем статик на форму
            this.Controls.Add(runawayStatic);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 1. Получаем текущие координаты мыши на форме
            Point mousePos = e.Location;

            // 2. Вычисляем границы "опасной зоны" вокруг статика
            int dangerLeft = runawayStatic.Left - DangerZone;
            int dangerRight = runawayStatic.Right + DangerZone;
            int dangerTop = runawayStatic.Top - DangerZone;
            int dangerBottom = runawayStatic.Bottom + DangerZone;

            // 3. Проверяем, вошел ли курсор в опасную зону
            if (mousePos.X >= dangerLeft && mousePos.X <= dangerRight &&
                mousePos.Y >= dangerTop && mousePos.Y <= dangerBottom)
            {
                // Курсор слишком близко! Статик должен убежать
                MoveStaticToRandomPlace();
            }
        }

        private void MoveStaticToRandomPlace()
        {
            // Вычисляем максимально возможные координаты X и Y, 
            // чтобы статик гарантированно не вылезал за границы формы (ClientSize)
            int maxX = this.ClientSize.Width - runawayStatic.Width;
            int maxY = this.ClientSize.Height - runawayStatic.Height;

            // Защита от ошибок, если форму сжали до микроскопических размеров
            if (maxX <= 0 || maxY <= 0) return;

            // Генерируем новые случайные координаты
            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            // Перемещаем статик в новую точку
            runawayStatic.Location = new Point(newX, newY);
        }
    }
}