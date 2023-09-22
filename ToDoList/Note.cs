using System;

namespace ToDoList
{
    public class Note
    {
        private static int nextId = 1;

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Note(string title)
        {
            Id = nextId++;
            Title = title;
            Date = DateTime.Now;
        }
    }
}
