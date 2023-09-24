using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDoList.Domain;

namespace ToDoList
{
    public class Note : INotifyPropertyChanged
    {
        #region Properties

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

        private PriorityItem priority;
        public PriorityItem Priority
        {
            get => priority;
            set
            {
                priority = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public Note(string title, PriorityItem priority)
        {
            Id = nextId++;
            Title = title;
            Date = DateTime.Now;
            Priority = priority;
        }

        public Note(string title) : this(title, null)
        {

        }

        public Note()
        {

        }

        #endregion

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
