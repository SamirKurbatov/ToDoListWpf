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

    public IEnumerable<Category> Categories { get; }

    public IEnumerable<string> PriorityItems { get; }

    public string Name
    {
        get => GetValue(note.Name);
        set => SetValue(value);
    }

    public string Priority
    {
        get => GetValue(note.Priority);
        set => SetValue(value);
    }

    public DateTime CreatedDate
    {
        get => GetValue(note.CreatedDate);
        set => SetValue(value);
    }

    public Category Category
    {
        get => GetValue(note.Category);
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
        : this(new Note(), Enumerable.Empty<Category>(), Enumerable.Empty<string>()) { }

    public EditViewModel(Note note, IEnumerable<Category> categories, IEnumerable<string> priorityItems)
    {
        Categories = categories;
        PriorityItems = priorityItems;
        this.note = note;
    }
    #endregion

    #region Commands
    private ICommand? commitCommand;
    public ICommand? CommitCommand
        => commitCommand ??= new LambdaCommand(OnCommitCommand, CanCommitCommand);

    public void OnCommitCommand(object n) => Commit();

    public bool CanCommitCommand(object n) => true;


    private ICommand? regectCommand;
    public ICommand? RegectCommand
        => regectCommand ??= new LambdaCommand(OnRegectCommand, CanRegectCommand);
    public void OnRegectCommand(object n) => Regect();

    public bool CanRegectCommand(object n)
        => Values.Count > 0;

    private ICommand? cancelDialogCommand;
    public ICommand? CloseDialogCommand
        => cancelDialogCommand ??= new LambdaCommand(OnCloseDialogCommand);

    public void OnCloseDialogCommand(object n)
    {
        var result = n is not null && Convert.ToBoolean(n);
        if (result)
        {
            Commit();
        }
        Complete?.Invoke(this, result);
    }

    #endregion

    private void Commit()
    {
        var type = note.GetType();

        foreach (var (propName, value) in Values)
        {
            var property = type.GetProperty(propName);
            if (property is not { CanWrite: true }) continue;

            property.SetValue(note, value);
        }
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
