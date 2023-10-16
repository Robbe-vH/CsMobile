using System.ComponentModel;

namespace BindingExamples.Models

{
    public class Actor : INotifyPropertyChanged

    {
        private string name;
        private string firstName;

        public string Name
        {
            get => name;

            set
            {
                name = value;

                RaiseEventChanged(nameof(Name));
            }
        }

        public string FirstName
        {
            get => firstName;

            set
            {
                firstName = value;

                RaiseEventChanged(nameof(FirstName));
            }
        }

        public string ProfilePicture { get; set; }
        public int Birthyear { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseEventChanged(string propertyName)

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}