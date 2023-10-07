using System.Collections.Generic;
using ToDoList.Data.Entities.Base;

namespace ToDoList.Data.Entities
{
    public class Group : NamedEntity
    {
        public ICollection<Note> Notes { get; set; } = new List<Note>()
        {
            new Note()
            {
                Id = 0,
                Name = "Почистить зубы",
            },

            new Note()
            {
                Id = 1,
                Name = "Помыть посуду",
            },

            new Note()
            {
                Id = 2,
                Name = "Вымыть пол",
            }
        };
    }
}
