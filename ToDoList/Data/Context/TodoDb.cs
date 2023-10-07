using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using ToDoList.Data.Entities;

namespace ToDoList.Data.Context
{
    public class TodoDb : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<Group> Groups { get; set; }

        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var random = new Random();

            var groupsName = new string[] { "Программирование", "Бытовуха", "Чето еще" };

            var groups = Enumerable.Range(0, 10)
                .Select(i => new Group
                {
                    Id = i,
                    Name = groupsName[random.Next(0, groupsName.Length)],
                })
                .ToArray();

            modelBuilder.Entity<Group>().HasData(groups);
        }
    }
}
