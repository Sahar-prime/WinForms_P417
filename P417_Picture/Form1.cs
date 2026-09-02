namespace P417_Picture
{
    public partial class Form1 : Form
    {
        private Bitmap currentBitmap; // Изначальный фон
        private Stack<Bitmap> history = new Stack<Bitmap>(); // История (для отката)
        Point prevPoint; // Предыдущая точка
        private bool isDrawing = false;  // Флаг рисования
        private Color currentColor = Color.Black;
        private int penSize = 5;
        private enum ToolType
        {
            Pen,
            Eraser,
            Fill,
            Rectangle,
            Ellipse,
        }
        private ToolType currentTool = ToolType.Pen;
        private Point startPoint;
        private bool isShapeDrawing = false;

        public Form1()
        {
            InitializeComponent();
            InitializeEditor();
        }

        private void InitializeEditor()
        {
            Button btnPen = new Button() { Text = "Карандаш", Tag = ToolType.Pen };
            Button btnEraser = new Button() { Text = "Ластик", Tag = ToolType.Eraser };
            Button btnFill = new Button() { Text = "Заливка", Tag = ToolType.Fill };
            Button btnRectangle = new Button() { Text = "Прямоугольник", Tag = ToolType.Rectangle };
            Button btnEllipse = new Button() { Text = "Эллипс", Tag = ToolType.Ellipse };
            Button btnColor = new Button() { Text = "Цвет" };
            Button btnUndo = new Button() { Text = "Отменить" };
            Button btnClear = new Button() { Text = "Очистить" };

            ToolPanel.Controls.AddRange(new Control[] {
                btnPen,
                btnEraser,
                btnFill,
                btnRectangle,
                btnEllipse,
                btnColor ,
                btnUndo,
                btnClear
            });

            btnPen.Click += (s, e) => currentTool = ToolType.Pen;
            btnEraser.Click += (s, e) => currentTool = ToolType.Eraser;
            btnFill.Click += (s, e) => currentTool = ToolType.Fill;
            btnRectangle.Click += (s, e) => currentTool = ToolType.Rectangle;
            btnEllipse.Click += (s, e) => currentTool = ToolType.Ellipse;
            btnColor.Click += (s, e) =>
            { ColorDialog cd = new ColorDialog(); if(cd.ShowDialog () == DialogResult.OK) currentColor = cd.Color; };
                    
            btnUndo.Click += (s, e) => Undo();
            //btnClear.Click += (s, e) => Clear();

            InitNewBitmap(800, 600);
            history = new Stack<Bitmap>();
        }

        private void InitNewBitmap(int width, int height) 
        {
            currentBitmap = new Bitmap(width, height);
            using (var g = Graphics.FromImage(currentBitmap)) 
            {
                g.Clear(Color.White);
            }
            var pb = this.Controls[0] as PictureBox;
            pb.Image = currentBitmap;
            history?.Clear();
        }

        private void SaveState() 
        {
            if (currentBitmap != null) history.Push(new Bitmap(currentBitmap));
        }
        private void Undo() 
        {
            if (history.Count > 0) 
            {
                currentBitmap = history.Pop();
                var pb = this.Controls[0] as PictureBox;
                pb.Image = currentBitmap;
                pb.Invalidate();
            }
        
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if()
        }
    }
}
