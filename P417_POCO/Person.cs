using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace P417_POCO
{
    public class Person : INotifyPropertyChanged
    {
        string name = "";
        int age;
        public event PropertyChangedEventHandler? PropertyChanged;
        public int Id { get; set; }
        public string Name 
        {
            get => name;
            set
            {
                if(name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Age 
        {
            get => age; 
            set
            {
                if(age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public override string ToString() => name;
    }
}
