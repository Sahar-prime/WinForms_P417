namespace WinForms_P417
{
    public partial class Child : Form
    {
        Parent _parent;
        public Child()
        {
            InitializeComponent();
        }

        public Child(string str)
        {
            //Перечадача через конструктор
            InitializeComponent();
            textBox1.Text = str;
        }

        public Child(Parent parent)
        {
            //Перечадача через конструктор
            InitializeComponent();
            _parent = parent;
        }

        public void SetTText(string value)//Передача через метод\свойство
        { textBox1.Text = value; }
        public string GetTText()//Передача через метод\свойство
        { return textBox1.Text; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DialogResult ShowDialog(string str) // передача данных через перегрузку метода
        {
            textBox1.Text = str; // при вызове метода в родительском классе вызовется данный метод
            return ShowDialog(); // внутри метода, назначаем данные и вызываем обычный ShowDialog
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnConst_Click(object sender, EventArgs e)
        {

        }
    }
}