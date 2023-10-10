using System.Collections;
using System.Collections.Generic;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Infrastructure.Services.Interfaces
{
    public interface INotesManager
    {
        IRepository<Category> CategoriesRepo { get; }

        IRepository<Note> NotesRepo { get; }

        public Note AddNote(string name, string priority, string category);

        public Note ChangeCategory(Note note, string category);

        Category AddCategory(string name);

        public bool Remove(Note note);
    }
}
