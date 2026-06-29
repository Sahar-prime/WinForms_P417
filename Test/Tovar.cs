namespace Test
{
    public class Tovar
    {
        string _name;
        string _made_in;
        double _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Made_in 
        {
            get { return _made_in; }
            set { _made_in = value; }
        }
        public double Price 
        {
            get { return _price; }
            set 
            { 
                _price = value;
                if (_price < 0)
                {
                    MessageBox.Show("Цена не может быть отрицательной! Устанавливается значение по умолчанию.",
                        "Ошибка цены");
                    _price = 0;
                }
            }
        }

        public Tovar (string name, string made_in, double price)
        {
            _name = name;
            _made_in = made_in;
            _price = price;
        }

        public Tovar() : this("Unknown", "Unknown", 0.0) { }

        public override string ToString() 
            => $"Название: {Name}, Страна производитель: {Made_in}, Стоимость: {Price}";
    }
}