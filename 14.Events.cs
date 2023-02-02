using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DexTraining
{
    public class PersonWithEventExample: INotifyPropertyChanged
    {
        private string? name;
        public string? Name
        {  
            get { return name; } 
            set 
            { 
                name = value; 
                OnPropertyChanged();
            }
                    
        }

        public PersonWithEventExample(string name) => this.name = name;
        

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
