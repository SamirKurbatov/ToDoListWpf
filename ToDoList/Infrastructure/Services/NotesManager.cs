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
        private readonly IRepository<Note> NotesRepo;

        private readonly IRepository<Category> CategoriesRepo;

        public IEnumerable<Note> Notes => NotesRepo.Items;

        public IEnumerable<Category> Categories => CategoriesRepo.Items;

        public NotesManager(IRepository<Note> notesRepo, IRepository<Category> categoriesRepo)
        {
            NotesRepo = notesRepo;
            CategoriesRepo = categoriesRepo;
        }

        public Note AddNote(string name, PriorityItem priority, string category)
        {
            var note = new Note
            {
                Name = name,
                PriorityItem = priority,
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
    }

}
