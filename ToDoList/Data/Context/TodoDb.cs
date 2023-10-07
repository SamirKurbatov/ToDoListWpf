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

            var random = new Random();

            var groupsName = new string[] { "Программирование", "Бытовуха", "Чето еще" };

            var priorities = new PriorityItem[]
            {
                new PriorityItem(ePriorityType.Low),
                new PriorityItem(ePriorityType.Medium),
                new PriorityItem(ePriorityType.High)
            };

            var notesName = new string[] { "Сделать петпроект", "Литкод", "Пылесосить" };

            var groups = Enumerable.Range(0, 10)
                .Select(i => new Category
                {
                    Id = i,
                    Name = groupsName[random.Next(0, groupsName.Length)],
                })
                .ToArray();



            var notes = Enumerable.Range(0, 10)
                .Select(n => new Note
                {
                    Name = notesName[random.Next(0, notesName.Length)],
                    PriorityItem = priorities[random.Next(0, notesName.Length)],
                })
                .ToArray();

            modelBuilder.Entity<Category>().HasIndex(d => d.Name);
            modelBuilder.Entity<Category>()
                .HasMany(g => g.Notes)
                .WithOne(e => e.Category)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>().HasData(groups);

            modelBuilder.Entity<Note>().HasIndex(note => new { note.Name, note.PriorityItem, note.Category });
            modelBuilder.Entity<Note>().HasData(notes);
        }
    }
}
