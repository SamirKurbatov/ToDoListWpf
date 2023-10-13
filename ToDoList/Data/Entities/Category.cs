using System.Collections.Generic;
using ToDoList.Data.Entities.Base;

namespace ToDoList.Data.Entities
{
    public class Category : NamedEntity
    {
        public ICollection<Note> Notes { get; set; }
    }
}

