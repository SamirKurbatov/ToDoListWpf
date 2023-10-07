using Microsoft.EntityFrameworkCore;
using System.Linq;
using ToDoList.Data.Context;
using ToDoList.Data.Entities;

namespace ToDoList.Infrastructure.Services
{
    internal class CategoriesRepository : DbRepository<Category>
    {
        public override IQueryable<Category> Items => Set.Include(e => e.Notes);

        public CategoriesRepository(TodoDb database) : base(database)
        {
        }
    }
}
