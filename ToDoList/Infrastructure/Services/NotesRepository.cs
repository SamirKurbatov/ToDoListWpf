using Microsoft.EntityFrameworkCore;
using System.Linq;
using ToDoList.Data.Context;
using ToDoList.Data.Entities;

namespace ToDoList.Infrastructure.Services
{
    internal class NotesRepository : DbRepository<Note>
    {
        public override IQueryable<Note> Items => Set.Include(e => e.Category);

        public NotesRepository(TodoDb db) : base(db)
        {
            
        }
    }
}
