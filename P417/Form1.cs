using Timer = System.Windows.Forms.Timer;

namespace WinForms_P417
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Timer vtimer = new Timer();
        Timer vtimerDay = new Timer();
        public Form1()
        {
            InitializeComponent();
            stop_btn.Enabled = false;

            vtimer.Tick += new EventHandler(ShowTimer);
            label2.Text = DateTime.Now.ToLongTimeString();
            vtimerDay.Tick += new EventHandler(ShowTime);
            vtimerDay.Interval = 200;
            vtimerDay.Start();
        }
        private void ShowTime(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }
        private void ShowTimer(object sender, EventArgs e)
        {
            textBox2.Text = vtimer.Interval.ToString();
            vtimer.Stop();
            stop_btn.Enabled = false;
            MessageBox.Show("Таймер Отработал!", "Таймер");
        }

        int count = 1;
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
            textBox2.Text = vtimer.Interval.ToString();
            vtimer.Start();
            start_btn.Enabled = false;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            vtimer.Stop();
            MessageBox.Show("Таймер не успел отработать! Принудительное отключение.", "Таймер");
            stop_btn.Enabled = false;
        }
    }
}