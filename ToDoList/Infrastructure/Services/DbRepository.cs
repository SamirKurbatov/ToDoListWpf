﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using ToDoList.Data.Context;
using ToDoList.Data.Entities.Base;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal class DbRepository<T> : IRepository<T>, IDisposable where T : Entity, new()
    {
        public DbRepository(IDbContextFactory<TodoDb> db)
        {
            this.database = db.CreateDbContext();
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

            database.Entry(item).State = EntityState.Deleted;

            if (AutoSaveChanges)
            {
                database.SaveChanges();
            }

            return true;
        }

        public T Update(T item)
        {
            try
            {
                database.Entry(item).State = EntityState.Modified;
                if (AutoSaveChanges)
                {
                    database.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                foreach (var entry in ex.Entries)
                {
                    var databaseEntry = entry.GetDatabaseValues();

                    if (databaseEntry == null)
                    {
                        Set.Add(item);
                    }
                    else
                    {
                        entry.OriginalValues.SetValues(databaseEntry);
                    }
                }
            }

            database.SaveChanges();
            return item;
        }

        public void Dispose() => Dispose(true);


        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            database.Dispose();
        }
    }

}
