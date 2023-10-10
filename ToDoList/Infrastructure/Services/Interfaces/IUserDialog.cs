﻿using System.Collections;
using System.Collections.Generic;
using ToDoList.Data.Entities;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services;

public interface IUserDialog
{
    bool CanEdit(Note note);
}
