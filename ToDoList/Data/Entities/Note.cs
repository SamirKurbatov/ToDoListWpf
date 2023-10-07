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
        public Note()
        {
            CreatedDate = DateTime.Now;
            PriorityItem = new PriorityItem(ePriorityType.None);
        }

        public DateTime CreatedDate { get; set; }

        public PriorityItem PriorityItem { get; set; }

        public string Category { get; set; }

        public int GroupId { get; set; }
    }
}
