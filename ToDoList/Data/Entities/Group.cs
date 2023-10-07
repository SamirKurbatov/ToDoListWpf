using System.Collections.Generic;
using ToDoList.Data.Entities.Base;

namespace ToDoList.Data.Entities
{
    public class Group : NamedEntity
    {
        public ICollection<Note> Notes { get; set; }
    }
}
