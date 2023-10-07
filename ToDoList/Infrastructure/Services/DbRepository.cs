using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.RegularExpressions;
using ToDoList.Data.Context;
using ToDoList.Data.Entities.Base;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal class DbRepository<T> : IRepository<T> where T : Entity, new()
    {
        public DbRepository(TodoDb database)
        {
            this.database = database;
            Set = database.Set<T>();
        }

        private readonly TodoDb database;

        protected DbSet<T> Set { get; }

        public virtual IQueryable<T> Items => Set;

        public bool AutoSaveChanges { get; set; } = true;

        public T Add(T item)
        {
            Set.Add(item);

            if (AutoSaveChanges)
            {
                database.SaveChanges();
            }

            return item;
        }

        public T Get(int id)
        {
            return Items is DbSet<T> set
            ? set.Find(id)
            : Items.FirstOrDefault(e => e.Id == id);
        }



        public bool Remove(int id)
        {
            var item = Set.Local.FirstOrDefault(x => x.Id == id)
                ?? Set.Select(i => new T { Id = i.Id }).FirstOrDefault(x => x.Id == id);
            if (item is null)
            {
                return false;
            }

            database.Entry(item).State = EntityState.Modified;

            if (AutoSaveChanges)
            {
                database.SaveChanges();
            }

            return true;
        }

        public T Update(T item)
        {
            database.Entry(item).State = EntityState.Modified;
            if (AutoSaveChanges)
            {
                database.SaveChanges();
            }
            return item;
        }
    }

}
