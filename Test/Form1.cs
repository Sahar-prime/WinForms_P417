namespace Test
{
    public partial class MainForm : Form
    {
        Tovar t = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар из списка!", "Ошибка");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            t = new Tovar();
            DopForm addForm = new DopForm(t, true);
            if (addForm.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(t);
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар из списка!", "Ошибка");
                return;
            }
            int n = listBox1.SelectedIndex;
            t  = (Tovar)listBox1.Items[n];
            DopForm editForm = new DopForm(t, false);
            editForm.ShowDialog();
            listBox1.Items.RemoveAt(n);
            listBox1.Items.Insert(n, t);
            listBox1.SelectedIndex = n;
        }
    }
}