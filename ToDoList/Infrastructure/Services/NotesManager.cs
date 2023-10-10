using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal class NotesManager : INotesManager
    {
        public IRepository<Note> NotesRepo { get; }

        public IRepository<Category> CategoriesRepo { get; }

        public NotesManager(IRepository<Note> notesRepo, IRepository<Category> categoriesRepo)
        {
            NotesRepo = notesRepo;
            CategoriesRepo = categoriesRepo;
        }

        public Note AddNote(string name, string priority, string category)
        {
            var note = new Note
            {
                Name = name,
                Priority = priority,
                CreatedDate = DateTime.UtcNow,
                Category = AddCategory(category),
            };

            NotesRepo.Add(note);

            return note;
        }

        public Category AddCategory(string name)
        {
            return CategoriesRepo.Items.FirstOrDefault(d => d.Name == name) is { } category
                ? category
                : CategoriesRepo.Add(new Category { Name = name });
        }

        public Note ChangeCategory(Note note, string categoryName)
        {
            note.Category = AddCategory(categoryName);

            return NotesRepo.Update(note);
        }


        public Note ChangePriority(Note note, string priority)
        {
            note.Priority = priority.ToString();

            return NotesRepo.Update(note);
        }


        public bool Remove(Note note)
        => note is null
            ? throw new ArgumentNullException(nameof(note))
            : NotesRepo.Remove(note.Id);
    }

}
