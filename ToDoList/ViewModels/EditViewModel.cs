using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDoList.Domain;

namespace ToDoList;

public class EditViewModel
{
    private readonly Note note;

    public IEnumerable<Note> Notes { get; set; }

    public IEnumerable<PriorityItem> PriorityItems { get; set;  }

    public string Title { get => note.Title; set { } }

    public PriorityItem Priority { get => note.Priority; set { } }

    #region Constructors


    public EditViewModel() 
        : this (new Note(),Enumerable.Empty<Note>(), Enumerable.Empty<PriorityItem>()) { }

    public EditViewModel(Note note, IEnumerable<Note> notes, IEnumerable<PriorityItem> items)
    {
        this.note = note;
        Notes = notes;
        PriorityItems = items;
    }
    #endregion

    #region Commands
    private ICommand? commitCommand;
    public ICommand? CommitCommand
        => commitCommand ??= new LambdaCommand(OnCommitCommand, CanCommitCommand);

    public void OnCommitCommand(object n)
    {

    }

    public bool CanCommitCommand(object n)
    {
        return true;
    }

    private ICommand? regectCommand;
    public ICommand? RegectCommand
        => regectCommand ??= new LambdaCommand(OnRegectCommand, CanRegectCommand);
    public void OnRegectCommand(object n)
    {

    }
    public bool CanRegectCommand(object n)
    {
        return true;
    }

    private ICommand? cancelCommand;
    public ICommand? CancelCommand
        => cancelCommand ??= new LambdaCommand(OnCancelCommand, CanCancelCommand);

    public void OnCancelCommand(object n)
    {

    }

    public bool CanCancelCommand(object n)
    {
        return true;
    }
    #endregion
}
