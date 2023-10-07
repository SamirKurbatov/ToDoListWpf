using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDoList.Data.Entities.Base;
using ToDoList.Data.Models;

namespace ToDoList.Data.Entities
{
    public class Note : NamedEntity
    {
        public DateTime Date { get; set; }

        public PriorityItem PriorityItem { get; set; }
    }
}
