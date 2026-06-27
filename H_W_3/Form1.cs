namespace H_W_3
{
    public partial class Form1 : Form
    {
        // Отступ прямоугольника от границ рабочей области
        private const int PaddingAmount = 25;

        public Form1()
        {
            InitializeComponent();
            // Включаем двойную буферизацию, чтобы заголовок и графика не мерцали
            this.DoubleBuffered = true;
        }

        // Вспомогательный метод для расчета размеров прямоугольника
        private Rectangle GetTargetRectangle()
        {
            return new Rectangle(
                PaddingAmount,
                PaddingAmount,
                this.ClientSize.Width - (PaddingAmount * 2),
                this.ClientSize.Height - (PaddingAmount * 2)
            );
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = GetTargetRectangle();
            using (Pen pen = new Pen(Color.Red, 1)) // Красный цвет для наглядности
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверка нажатия Левой Кнопки Мыши
            if (e.Button == MouseButtons.Left)
            {
                // Если зажат Ctrl — закрываем приложение
                if ((ModifierKeys & Keys.Control) == Keys.Control)
                {
                    this.Close();
                    return;
                }

                Rectangle rect = GetTargetRectangle();
                string message = "";

                // Проверка нахождения на границе с допуском в 1 пиксель
                if (Math.Abs(e.X - rect.Left) <= 1 || Math.Abs(e.X - rect.Right) <= 1 ||
                    Math.Abs(e.Y - rect.Top) <= 1 || Math.Abs(e.Y - rect.Bottom) <= 1)
                {
                    if (e.X >= rect.Left && e.X <= rect.Right && e.Y >= rect.Top && e.Y <= rect.Bottom)
                    {
                        message = "Точка находится НА ГРАНИЦЕ прямоугольника.";
                    }
                }
                // Проверка нахождения внутри
                else if (rect.Contains(e.Location))
                {
                    message = "Точка находится ВНУТРИ прямоугольника.";
                }
                // В противном случае — снаружи
                else
                {
                    message = "Точка находится СНАРУЖИ прямоугольника.";
                }

                MessageBox.Show(message, "Положение точки");
            }
            // Проверка нажатия Правой Кнопки Мыши
            else if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Ширина = {this.ClientSize.Width}, Высота = {this.ClientSize.Height}";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X}, Y = {e.Y}";
        }
    }
}