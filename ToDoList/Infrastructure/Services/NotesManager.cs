using System.Linq;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    class NotesManager : INotesManager
    {
        private readonly IRepository<Note> Notes;

        private readonly IRepository<Category> Categories;

        public Note AddNote(string name, PriorityItem priority, string category)
        {
            var note = new Note
            {
                Name = name,
                PriorityItem = priority,
                Category = category,
            };

            Notes.Add(note);

            return note;
        }

        public Note ChangeGroup(Note note, string categoryName)
        {
            if (Categories.Items.FirstOrDefault(i => i.Name == categoryName) is not { } category)
            {
                category = new Category { Name = categoryName };
                Categories.Add(category);
            }

            Notes.Update(note);

            return note;

        }
    }

}
