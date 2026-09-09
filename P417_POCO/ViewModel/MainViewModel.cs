using P417_POCO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class MainViewModel : INotifyPropertyChanged
{
    private int _selectedId;

    public event PropertyChangedEventHandler? PropertyChanged;

    public Person? SelectedPerson => People.FirstOrDefault(p => p.Id == _selectedId);

    public int SelectedId
    {
        get => _selectedId;
        set
        {
            if (_selectedId != value)
            {
                _selectedId = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedPerson));
            }
        }
    }

    public BindingList<Person> People { get; }

    public MainViewModel()
    {
        People = new BindingList<Person>()
            {
                new Person { Id = 1, Name = "Tom", Age = 24 },
                new Person { Id = 2, Name = "Bob", Age = 32 },
                new Person { Id = 3, Name = "Sam", Age = 40 }
            };
        SelectedId = 2;
    }

    public void AddCharacter(string name, int age)
    {
        int newId = People.Any() ? People.Max(p => p.Id) + 1 : 1;

        var newPerson = new Person { Id = newId, Name = name, Age = age };

        People.Add(newPerson);   
        SelectedId = newPerson.Id;
    }

    protected void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}