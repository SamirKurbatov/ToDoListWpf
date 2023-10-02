using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList.Domain
{
    public class Group : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private int noteCount;
        public int NoteCount
        {
            get => noteCount;
            set
            {
                noteCount = value;
                OnPropertyChanged();
            }
        }

        public Group(string name)
        {
            Name = name;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
