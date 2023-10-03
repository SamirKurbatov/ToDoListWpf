using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ToDoList.Data;
using ToDoList.Domain;
using ToDoList.Infrastructure.Comparers;
using ToDoList.Infrastructure.Services;

namespace ToDoList;

public class MainViewModel : ViewModel
{
    private IUserDialog userDialog;

    public MainViewModel(IUserDialog userDialog)
    {
        this.userDialog = userDialog;
    }

    private ObservableCollection<Note> notes;

    public ObservableCollection<Note> Notes
    {
        get => notes;
        set => Set(ref notes, value);
    }

    private ObservableCollection<PriorityItem> priorityItems;

    public ObservableCollection<PriorityItem> PriorityItems
    {
        get => priorityItems;
        set => Set(ref priorityItems, value);
    }

    private Note selectedNote;

    public Note SelectedNote
    {
        get => selectedNote;
        set => Set(ref selectedNote, value);
    }

    #region Commands

    private ICommand loadDataCommand;

    public ICommand LoadDataCommand
            => loadDataCommand ??= new RelayCommand(OnLoadData);

    public void OnLoadData() {
        Notes = new ObservableCollection<Note>(TodoData.Notes);
        PriorityItems = new ObservableCollection<PriorityItem>(TodoData.PriorityItems);
    }

   
    private bool CanLoadDataCommandExecute()
    {
        return true;
    }

    private ICommand removeCommand;
    public ICommand RemoveCommand
            => removeCommand ??= new LambdaCommand(OnRemove, CanRemove);
    public void OnRemove(object p)
    {
        Notes.Remove(SelectedNote);
    }

    public bool CanRemove(object p) => p is Note && SelectedNote != null;


    private ICommand addCommand;
    public ICommand AddCommand
            => addCommand ??= new LambdaCommand(OnAdd);
    public void OnAdd(object p)
    {
        var addNoteWindow = new AddNoteWindow();
        addNoteWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        addNoteWindow.ShowDialog();
    }

    private ICommand editCommand;
    public ICommand EditCommand
            => editCommand ??= new LambdaCommand(OnEdit);

    public void OnEdit(object p)
    {
        var note = (Note)p;
        if (userDialog.Edit(note))
        {
            // Сохранить note в бд
            // Обновить состояние интерфейса
        }
        else
        {
            // nothing
        }
    }


    //[RelayCommand]
    //public void OrderByPriority()
    //{
    //    var filtedNotes = Notes.OrderBy(x => x, new PriorityComparer());
    //    Notes = new ObservableCollection<Note>(filtedNotes);
    //}

    //[RelayCommand]
    //public void OrderByDate()
    //{
    //    var filtedNotes = Notes.OrderByDescending(x => x.Date);
    //    Notes = new ObservableCollection<Note>(filtedNotes);
    //}

    //[RelayCommand]
    //public void OrderByTitle()
    //{
    //    var filtredNotes = Notes.OrderBy(x => x.Title);
    //    Notes = new ObservableCollection<Note>(filtredNotes);
    //}
    #endregion
}

internal abstract class Command : ICommand
{
    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

    bool ICommand.CanExecute(object parameter) => CanExecute(parameter);

    void ICommand.Execute(object parameter)
    {
        if (((ICommand)this).CanExecute(parameter))
            Execute(parameter);
    }

    protected virtual bool CanExecute(object p) => true;

    protected abstract void Execute(object p);
}

internal class LambdaCommand : Command
{
    private readonly Action<object> _Execute;
    private readonly Func<object, bool> _CanExecute;

    public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
    {
        _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
        _CanExecute = CanExecute;
    }

    protected override bool CanExecute(object p) => _CanExecute?.Invoke(p) ?? true;

    protected override void Execute(object p) => _Execute(p);
}