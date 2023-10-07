using System.Collections;
using System.Collections.Generic;
using ToDoList.Data.Entities;

namespace ToDoList.Infrastructure.Services;

public interface IUserDialog
{
    bool CanEdit(Note note);
    bool CanAdd(ICollection<Note> notes);
}
