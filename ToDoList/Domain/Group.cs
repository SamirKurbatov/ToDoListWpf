using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList
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
                noteCount = Notes.Count;
                OnPropertyChanged();
            }
        }

        public List<Note> Notes { get; set; }

        public Group(string name, List<Note> notes)
        {
            Name = name;
            Notes = notes;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
