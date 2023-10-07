using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDoList.Commands;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure;

namespace ToDoList;

public class EditViewModel : ViewModel
{
    public event EventHandler<EventArgs<bool>> Complete;

    private readonly Dictionary<string, object> Values = new();

    #region Propereties

    private readonly Note note;

    public IEnumerable<Note> Notes { get; }

    public IEnumerable<PriorityItem> PriorityItems { get; }

    public string Title
    {
        get => GetValue(note.Name);
        set => SetValue(value);
    }

    public PriorityItem PriorityItem
    {
        get => GetValue(note.PriorityItem);
        set => SetValue(value);
    }
    #endregion

    protected virtual bool SetValue(object value, [CallerMemberName] string propName = "")
    {
        if (Values.TryGetValue(propName, out var oldValue) && Equals(value, oldValue))
        {
            return false;
        }
        Values[propName] = value;
        OnPropertyChanged(propName);
        return true;
    }

    protected virtual T GetValue<T>(T @default, [CallerMemberName] string propName = "")
    {
        if (Values.TryGetValue(propName, out var value))
        {
            return (T)value;
        }
        return @default;
    }

    #region Constructors


    public EditViewModel()
        : this(new Note(), Enumerable.Empty<Note>(), Enumerable.Empty<PriorityItem>()) { }

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
        Commit();
        Complete?.Invoke(this, true);
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
        Regect();
    }
    public bool CanRegectCommand(object n)
        => Values.Count > 0;

    private ICommand? cancelCommand;
    public ICommand? CancelCommand
        => cancelCommand ??= new LambdaCommand(OnCancelCommand, CanCancelCommand);

    public void OnCancelCommand(object n)
    {
        Regect();
        Complete?.Invoke(this, false);
    }

    public bool CanCancelCommand(object n)
    {
        return true;
    }
    #endregion

    public void Commit()
    {
        var type = typeof(Note);

        foreach (var (propName, value) in Values)
        {
            var property = type.GetProperty(propName);
            if (property is null || !property.CanWrite) continue;

            property.SetValue(note, value);
        }

        Values.Clear();
    }

    public void Regect()
    {
        var properties = Values.Keys.ToArray();
        Values.Clear();
        foreach (var prop in properties)
        {
            OnPropertyChanged(prop);
        }
    }
}
