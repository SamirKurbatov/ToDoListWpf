using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Data.Context
{
    public class TodoDb : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //var groupsName = new string[] { "Программирование", "Бытовуха", "Чето еще" };

            //var priorities = new string[]
            //{
            //  ePriorityType.Low.ToString(),
            //  ePriorityType.Medium.ToString(),
            //  ePriorityType.High.ToString(),
            //};

            //var notesName = new string[] { "Сделать петпроект", "Литкод", "Пылесосить" };

            var groups = Enumerable.Range(1, 10)
                .Select(i => new Category
                {
                    Id = i,
                    Name = $"Группа {i}",
                })
                .ToArray();


            modelBuilder.Entity<Category>().HasIndex(c => c.Name);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Notes)
                .WithOne(e => e.Category)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>().HasData(groups);

            var random = new Random();

            var notes = Enumerable.Range(1, 100)
                .Select(i => new Note
                {
                    Id = i,
                    Name = $"Задача {i}",
                    Priority = $"Приоритет {i}",
                    CategoryId = groups[random.Next(0, groups.Length)].Id,
                })
                .ToArray();


            modelBuilder.Entity<Note>().HasIndex(note => new { note.Name, note.Priority, note.CreatedDate });
            modelBuilder.Entity<Note>().HasData(notes);
        }
    }
}
