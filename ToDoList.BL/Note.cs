using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoList
{
    public class Note : INotifyPropertyChanged
    {
        private static int nextId = 1;

        public int Id { get; set; }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date { get; set; }

        public Note(string title)
        {
            Id = nextId++;
            Title = title;
            Date = DateTime.Now;
        }

        public Note()
        {
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            }
        }

        public override string ToString()
        {
            return $"Id:{Id}\nНазвание: {Title}\nДата и время:{Date}";
        }
    }
}
