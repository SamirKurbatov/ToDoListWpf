using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ToDoList.Data.Entities.Base;
using ToDoList.Data.Models;

namespace ToDoList.Data.Entities
{
    public class Note : NamedEntity
    {
        public DateTime CreatedDate { get; set; }

        public string? Priority { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
