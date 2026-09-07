namespace P417_Picture
{
    public partial class Form1 : Form
    {
        private Bitmap currentBitmap;           // текущее изображение
        private Stack<Bitmap> history;          // стек для Undo
        private Point prevPoint;                // предыдущая позиция мыши
        private bool isDrawing = false;         // рисуем ли сейчас

        // Инструменты
        private enum Tool { Pen, Eraser, Rectangle, Ellipse, Fill }
        private Tool currentTool = Tool.Pen;
        private Color currentColor = Color.Black;
        private int penSize = 5;

        // Для фигур (прямоугольник/эллипс)
        private Point startPoint;
        private bool isShapeDrawing = false;
        public Form1()
        {
            InitializeComponent();
            InitializeEditor();
        }
        private void InitializeEditor()
        {
            // Настройка PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.AutoScroll = true;

            // Создаём новое изображение (белый фон)
            currentBitmap = new Bitmap(1920, 1080);
            using (var g = Graphics.FromImage(currentBitmap))
                g.Clear(Color.White);
            pictureBox1.Image = currentBitmap;
            history = new Stack<Bitmap>();

            // Добавляем кнопки в toolPanel (если он уже есть на форме)
            // Если toolPanel ещё нет, можно создать его прямо здесь
            if (toolPanel == null)
            {
                toolPanel = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 40 };
                this.Controls.Add(toolPanel);
            }

            // Создаём кнопки
            Button btnPen = new Button { Text = "Карандаш", Tag = Tool.Pen };
            Button btnEraser = new Button { Text = "Ластик", Tag = Tool.Eraser };
            Button btnRect = new Button { Text = "Прямоугольник", Tag = Tool.Rectangle };
            Button btnEllipse = new Button { Text = "Эллипс", Tag = Tool.Ellipse };
            Button btnFill = new Button { Text = "Заливка", Tag = Tool.Fill };
            Button btnColor = new Button { Text = "Цвет" };
            Button btnUndo = new Button { Text = "Отменить" };
            Button btnClear = new Button { Text = "Очистить" };

            // Фильтры (дополнительная панель)
            Button btnGray = new Button { Text = "Серый" };
            Button btnSepia = new Button { Text = "Сепия" };
            Button btnBlur = new Button { Text = "Размытие" };

            // Добавляем на панель
            toolPanel.Controls.AddRange(new Control[]
            {
                btnPen, btnEraser, btnRect, btnEllipse,
                btnFill, btnColor, btnUndo, btnClear, btnGray, btnSepia, btnBlur
            });

            // Подписка на события кнопок
            btnPen.Click += (s, e) => currentTool = Tool.Pen;
            btnEraser.Click += (s, e) => currentTool = Tool.Eraser;
            btnRect.Click += (s, e) => currentTool = Tool.Rectangle;
            btnEllipse.Click += (s, e) => currentTool = Tool.Ellipse;
            btnFill.Click += (s, e) => currentTool = Tool.Fill;
            btnColor.Click += (s, e) => { ColorDialog cd = new ColorDialog(); if (cd.ShowDialog() == DialogResult.OK) currentColor = cd.Color; };
            btnUndo.Click += (s, e) => Undo();
            btnClear.Click += (s, e) => ClearImage();

            btnGray.Click += (s, e) => ApplyFilter(ApplyGrayscale);
            btnSepia.Click += (s, e) => ApplyFilter(ApplySepia);
            btnBlur.Click += (s, e) => ApplyFilter(ApplyBlur);

            // Подписываем события мыши для pictureBox1
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }
        // ---------- СОБЫТИЯ МЫШИ ----------
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Для заливки – сразу выполняем по клику
            if (currentTool == Tool.Fill)
            {
                SaveState();
                Color target = currentBitmap.GetPixel(e.X, e.Y);
                FloodFill(e.X, e.Y, target, currentColor);
                pictureBox1.Invalidate();
                return;
            }

            // Для карандаша и ластика – начинаем рисование
            if (currentTool == Tool.Pen || currentTool == Tool.Eraser)
            {
                isDrawing = true;
                prevPoint = new Point(e.X, e.Y);
                SaveState(); // запоминаем состояние перед рисованием
                return;
            }

            // Для фигур – запоминаем стартовую точку
            if (currentTool == Tool.Rectangle || currentTool == Tool.Ellipse)
            {
                isShapeDrawing = true;
                startPoint = new Point(e.X, e.Y);
                // Не сохраняем состояние пока, сохраним при отпускании
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Рисование карандашом/ластиком
            if (isDrawing)
            {
                using (var g = Graphics.FromImage(currentBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Color drawColor = (currentTool == Tool.Eraser) ? Color.White : currentColor;
                    using (var pen = new Pen(drawColor, penSize))
                    {
                        g.DrawLine(pen, prevPoint, new Point(e.X, e.Y));
                    }
                }
                prevPoint = new Point(e.X, e.Y);
                pictureBox1.Invalidate();
            }

            // Предпросмотр фигуры (рисуем прямо на pictureBox поверх картинки)
            if (isShapeDrawing)
            {

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Завершаем рисование карандашом/ластиком
            if (isDrawing)
            {
                isDrawing = false;
                // состояние уже сохранено в MouseDown
                return;
            }

            // Завершаем рисование фигуры
            if (isShapeDrawing)
            {
                isShapeDrawing = false;
                // Рисуем фигуру окончательно на Bitmap
                using (var g = Graphics.FromImage(currentBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (var pen = new Pen(currentColor, penSize))
                    {
                        int x = Math.Min(startPoint.X, e.X);
                        int y = Math.Min(startPoint.Y, e.Y);
                        int w = Math.Abs(startPoint.X - e.X);
                        int h = Math.Abs(startPoint.Y - e.Y);
                        if (w == 0 || h == 0) return;
                        if (currentTool == Tool.Rectangle)
                            g.DrawRectangle(pen, x, y, w, h);
                        else if (currentTool == Tool.Ellipse)
                            g.DrawEllipse(pen, x, y, w, h);
                    }
                }
                SaveState(); // сохраняем после завершения фигуры
                pictureBox1.Invalidate();
            }
        }
        // ---------- ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ----------
        private void SaveState()
        {
            if (currentBitmap != null)
                history.Push(new Bitmap(currentBitmap));
        }

        private void Undo()
        {
            if (history.Count > 0)
            {
                currentBitmap = history.Pop();
                pictureBox1.Image = currentBitmap;
                pictureBox1.Invalidate();
            }
        }

        private void ClearImage()
        {
            SaveState();
            using (var g = Graphics.FromImage(currentBitmap))
                g.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        // Заливка (Flood Fill) – простая рекурсивная, но для больших картинок лучше стек
        private void FloodFill(int x, int y, Color targetColor, Color fillColor)
        {
            if (targetColor == fillColor) return;
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));
            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                if (p.X < 0 || p.X >= currentBitmap.Width || p.Y < 0 || p.Y >= currentBitmap.Height)
                    continue;
                Color c = currentBitmap.GetPixel(p.X, p.Y);
                if (c == targetColor)
                {
                    currentBitmap.SetPixel(p.X, p.Y, fillColor);
                    stack.Push(new Point(p.X - 1, p.Y));
                    stack.Push(new Point(p.X + 1, p.Y));
                    stack.Push(new Point(p.X, p.Y - 1));
                    stack.Push(new Point(p.X, p.Y + 1));
                }
            }
        }
        // ---------- ФИЛЬТРЫ ----------
        private void ApplyFilter(Func<Bitmap, Bitmap> filter)
        {
            if (currentBitmap == null) return;
            SaveState();
            currentBitmap = filter(currentBitmap);
            pictureBox1.Image = currentBitmap;
            pictureBox1.Invalidate();
        }

        private Bitmap ApplyGrayscale(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    byte gray = (byte)((c.R + c.G + c.B) / 3);
                    result.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            return result;
        }

        private Bitmap ApplySepia(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int r = (int)(c.R * 0.393 + c.G * 0.769 + c.B * 0.189);
                    int g = (int)(c.R * 0.349 + c.G * 0.686 + c.B * 0.168);
                    int b = (int)(c.R * 0.272 + c.G * 0.534 + c.B * 0.131);
                    result.SetPixel(x, y, Color.FromArgb(
                        Math.Min(255, r),
                        Math.Min(255, g),
                        Math.Min(255, b)
                    ));
                }
            return result;
        }
        private Bitmap ApplyBlur(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);
            for (int x = 1; x < source.Width - 1; x++)
                for (int y = 1; y < source.Height - 1; y++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    for (int dx = -1; dx <= 1; dx++)
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            Color c = source.GetPixel(x + dx, y + dy);
                            avgR += c.R;
                            avgG += c.G;
                            avgB += c.B;
                        }
                    avgR /= 9; avgG /= 9; avgB /= 9;
                    result.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            return result;
        }
    }
}
