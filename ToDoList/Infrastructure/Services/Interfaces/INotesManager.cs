using System.Collections;
using System.Collections.Generic;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Infrastructure.Services.Interfaces
{
    public interface INotesManager
    {
        IEnumerable<Category> Categories { get; }

        IEnumerable<Note> Notes { get; }

        public Note AddNote(string name, PriorityItem priority, string category);

        public Note ChangeCategory(Note note, string category);

        Category AddCategory(string name);
    }
}
