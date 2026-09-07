namespace My_Picture
{
    public partial class Form1 : Form
    {
        private Bitmap currentBitmap;
        private Stack<Bitmap> history;
        private Point prevPoint;
        private bool isDrawing = false;

        private enum Tool { Pen, Eraser, Rectangle, Ellipse, Fill }
        private Tool currentTool = Tool.Pen;
        private Color currentColor = Color.Black;
        private int penSize = 4;
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();

            history = new Stack<Bitmap>();

            currentBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(currentBitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = currentBitmap;

            cmbTools.Items.Clear();
            cmbTools.Items.AddRange(new object[] { "Перо", "Ластик", "Прямоугольник", "Эллипс", "Заливка" });
            cmbTools.SelectedIndex = 0;

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void SaveToHistory()
        {
            if (currentBitmap != null)
            {
                history.Push(new Bitmap(currentBitmap));
            }
        }

        private void cmbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTools.SelectedIndex)
            {
                case 0: currentTool = Tool.Pen; break;
                case 1: currentTool = Tool.Eraser; break;
                case 2: currentTool = Tool.Rectangle; break;
                case 3: currentTool = Tool.Ellipse; break;
                case 4: currentTool = Tool.Fill; break;
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                currentBitmap.Dispose();
                currentBitmap = history.Pop();
                pictureBox1.Image = currentBitmap;
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("История пуста!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            SaveToHistory();
            using (Graphics g = Graphics.FromImage(currentBitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Refresh();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    currentColor = cd.Color;
                    btn_color.BackColor = cd.Color;
                }
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            SaveToHistory();
            isDrawing = true;
            prevPoint = e.Location;
            startPoint = e.Location;

            if (currentTool == Tool.Fill)
            {
                Color targetColor = currentBitmap.GetPixel(e.X, e.Y);
                if (targetColor.ToArgb() != currentColor.ToArgb())
                {
                    FloodFill(currentBitmap, e.Location, targetColor, currentColor);
                    pictureBox1.Refresh();
                }
                isDrawing = false;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            if (currentTool == Tool.Pen || currentTool == Tool.Eraser)
            {
                using (Graphics g = Graphics.FromImage(currentBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    Color activeColor = (currentTool == Tool.Eraser) ? Color.White : currentColor;
                    using (Pen pen = new Pen(activeColor, penSize))
                    {
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(pen, prevPoint, e.Location);
                    }
                }
                prevPoint = e.Location;
                pictureBox1.Refresh();
            }
            else if (currentTool == Tool.Rectangle || currentTool == Tool.Ellipse)
            {
                prevPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;

            if (currentTool == Tool.Rectangle || currentTool == Tool.Ellipse)
            {
                using (Graphics g = Graphics.FromImage(currentBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(currentColor, penSize))
                    {
                        Rectangle rect = GetRectangle(startPoint, e.Location);
                        if (currentTool == Tool.Rectangle)
                            g.DrawRectangle(pen, rect);
                        else
                            g.DrawEllipse(pen, rect);
                    }
                }
                pictureBox1.Refresh();
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing && (currentTool == Tool.Rectangle || currentTool == Tool.Ellipse))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen previewPen = new Pen(currentColor, penSize))
                {
                    Rectangle rect = GetRectangle(startPoint, prevPoint);
                    if (currentTool == Tool.Rectangle)
                        e.Graphics.DrawRectangle(previewPen, rect);
                    else
                        e.Graphics.DrawEllipse(previewPen, rect);
                }
            }
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(pt);

            int targetNode = targetColor.ToArgb();
            int replacementNode = replacementColor.ToArgb();

            while (q.Count > 0)
            {
                Point n = q.Dequeue();
                if (n.X < 0 || n.X >= bmp.Width || n.Y < 0 || n.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(n.X, n.Y).ToArgb() == targetNode)
                {
                    bmp.SetPixel(n.X, n.Y, replacementColor);
                    q.Enqueue(new Point(n.X - 1, n.Y));
                    q.Enqueue(new Point(n.X + 1, n.Y));
                    q.Enqueue(new Point(n.X, n.Y - 1));
                    q.Enqueue(new Point(n.X, n.Y + 1));
                }
            }
        }
    }
}