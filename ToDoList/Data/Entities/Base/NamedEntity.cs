using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.Entities.Base
{
    public abstract class NamedEntity : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
