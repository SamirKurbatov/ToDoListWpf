using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDoList.Domain;

namespace ToDoList;

public class EditViewModel
{
    private readonly Note note;

    private readonly IEnumerable<Note> notes;

    public EditViewModel() : this (new Note(),Enumerable.Empty<Note>()) { }

    public EditViewModel(Note note, IEnumerable<Note> notes)
    {
        this.note = note;
        this.notes = notes;
    }
}
