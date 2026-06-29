namespace Test
{
    public partial class DopForm : Form
    {
        Tovar t;
        bool addNew;

        public DopForm(Tovar t, bool addNew)
        {
            InitializeComponent();
            this.t = t;
            this.addNew = addNew;
            if (addNew == false)
            {
                TB_Name.Text = t.Name;
                TB_Made.Text = t.Made_in;
                NUD_Price.Value = (decimal)t.Price;
                this.Text = "Редактирование товара";
            }
            else this.Text = "Добавление товара";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (
                TB_Name.Text == ""
                || TB_Made.Text == ""
                || NUD_Price.Value == 0
                )
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (t == null) t = new Tovar();
            t.Name = TB_Name.Text;
            t.Made_in = TB_Made.Text;
            t.Price = (double)NUD_Price.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}