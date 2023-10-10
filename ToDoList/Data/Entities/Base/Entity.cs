using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Data.Entities.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }
}
