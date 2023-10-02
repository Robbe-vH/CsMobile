
using System.ComponentModel;

namespace MainApp.Models
{
    internal class ToDoItem: INotifyPropertyChanged
    {
        public string Titel { get; set; }
        private bool _isKlaar;

        public bool IsKlaar
        {
            get { return _isKlaar; }
            set 
            { 
                _isKlaar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsKlaar")); 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsNietKlaar"));
            }
        }

        public bool IsNietKlaar
        { 
            get
            {
                return !_isKlaar;
            }
        }


        public ToDoItem(string titel, bool isklaar)
        {
            Titel = titel;
            IsKlaar = isklaar;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
