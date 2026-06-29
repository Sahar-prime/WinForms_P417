using Timer = System.Windows.Forms.Timer;

namespace WinForms_P417
{
    public partial class Parent : Form
    {
        int count = 1;
        int count_tick = 0;

        Random rnd = new Random();

        Timer vtimer = new Timer();
        Timer vtimerDay = new Timer();
        Timer vtime = new Timer();
        Timer ctimer = new Timer();

        Child f = null;

        public Parent()
        {
            InitializeComponent();
            stop_btn.Enabled = false;

            vtimer.Tick += new EventHandler(ShowTimer);
            label2.Text = DateTime.Now.ToLongTimeString();

            vtimerDay.Tick += new EventHandler(ShowTime);
            vtimerDay.Interval = 200;
            vtimerDay.Start();

            vtime.Tick += new EventHandler(ShowTick);
            vtime.Interval = 800;

            ctimer.Tick += new EventHandler(ChangeBackgroundColor);
            ctimer.Interval = 1000;
            ctimer.Start();

            toolTip1.SetToolTip(label2, "Время по МСК");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (f != null) f.Close();

            f = new Child();
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Child f = new Child(textBox2.Text); //передача по конструктору
            Child f = new Child();
            // f.SetTText(textBox2.Text); // передача по методу\свойству
            //f.ShowDialog(textBox2.Text); // передача через перегрузку ShowDialog
            if (f.ShowDialog() == DialogResult.OK)
                textBox2.Text = f.GetTText();
            MessageBox.Show("Конец программы окна 2");
        }

        private void ChangeBackgroundColor(object sender, EventArgs e)
        {
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void ShowTick(object sender, EventArgs e)
        {
            if (count_tick > 0)
            {
                count_tick--;
                progressBar1.Value++;
            }
        }

        private void ShowTime(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }
        private void ShowTimer(object sender, EventArgs e)
        {
            vtimer.Stop();
            vtime.Stop();
            stop_btn.Enabled = false;
            MessageBox.Show("Таймер Отработал!", "Таймер");
            start_btn.Enabled = true;
            progressBar1.Value = 0;
        }

        private void clickPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = count++.ToString();
            if (count == 11)
                MessageBox.Show("Вы достигли 10 кликов!", "УРА!!!!");
        }

        private void ClickPlusMove(object sender, EventArgs e)
        {
            int maxLeft = this.Size.Width - clickPlus.Width;
            int maxTop = this.Size.Height - clickPlus.Height;

            if (maxLeft <= 0 || maxTop <= 0) return;

            int newLeft = rnd.Next(300) + maxLeft;
            int newTop = rnd.Next(300) + maxTop;

            clickPlus.Margin = new Padding(newLeft, newTop, 0, 0);
        }

        private void clickPlus_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координаты мыши: X = " + e.X.ToString() + ", Y = " + e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "";
            if (e.Button == MouseButtons.Right)
                message = "Вы нажали правую кнопку мыши.";

            if (e.Button == MouseButtons.Left)
                message = "Вы нажали левую кнопку мыши.";

            message += "\n" + CoordinatesToString(e);

            MessageBox.Show(message, "Клик мыши", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Количетсво секунд должно быть больше 0!");
                return;
            }
            stop_btn.Enabled = true;
            vtimer.Interval = Decimal.ToInt32(numericUpDown1.Value) * 1000;

            count_tick = Decimal.ToInt32(numericUpDown1.Value);
            progressBar1.Maximum = count_tick;
            progressBar1.Minimum = 0;

            vtime.Start();
            vtimer.Start();

            start_btn.Enabled = false;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            vtimer.Stop();
            vtime.Stop();
            MessageBox.Show("Таймер не успел отработать! Принудительное отключение.", "Таймер");
            progressBar1.Value = 0;
            stop_btn.Enabled = false;
            start_btn.Enabled = true;
        }
    }
}