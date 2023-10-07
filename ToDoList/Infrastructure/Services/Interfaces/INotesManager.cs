using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Infrastructure.Services.Interfaces
{
    internal interface INotesManager
    {
        public Note AddNote(string name, PriorityItem priority, string category);
        public Note ChangeGroup(Note note, string category);
    }
}
