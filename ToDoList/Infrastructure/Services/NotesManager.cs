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

        public Note AddNote(string name, string priority, string category, DateTime createdDate)
        {
            var note = new Note
            {
                Name = name,
                Priority = priority,
                CreatedDate = createdDate,
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

        public Note ChangeNote(Note note, string categoryName, string priority)
        {
            var category = AddCategory(categoryName);
            note.Category = category;
            note.CategoryId = category.Id;
            note.Priority = priority;

            return NotesRepo.Update(note);
        }


        public bool Remove(Note note)
        => note is null
            ? throw new ArgumentNullException(nameof(note))
            : NotesRepo.Remove(note.Id);
    }

}
