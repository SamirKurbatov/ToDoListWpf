using System;
using System.Collections;
using System.Collections.Generic;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Infrastructure.Services.Interfaces
{
    // TODO обобщить интерфейсы
    public interface INotesManager
    {
        IRepository<Category> CategoriesRepo { get; }

        IRepository<Note> NotesRepo { get; }

        public Note AddNote(string name, string priority, string category, DateTime createdDate);

        public Note ChangeNote(Note note, string categor, string priority);

        Category AddCategory(string name);

        public bool Remove(Note note);
    }
}
