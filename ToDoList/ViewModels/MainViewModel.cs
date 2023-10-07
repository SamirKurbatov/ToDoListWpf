using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Data;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure.Services;

namespace ToDoList;

public class MainViewModel : ViewModel
{
    private IUserDialog userDialog;

    public MainViewModel(IUserDialog userDialog)
    {
        this.userDialog = userDialog;
    }

    #region Properties

    private ObservableCollection<Category> groups;
    public ObservableCollection<Category> Groups
    {
        get => groups;
        set => Set(ref groups, value);
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

    private Category selectedGroup;
    public Category SelectedGroup
    {
        get => selectedGroup;
        set
        {
            Set(ref selectedGroup, value);
        }
    }

    #endregion

    #region Commands

    private ICommand loadDataCommand;

    public ICommand LoadDataCommand
            => loadDataCommand ??= new LambdaCommand(OnLoadData, CanLoadDataCommandExecute);

    public void OnLoadData(object n)
    {
        PriorityItems = new ObservableCollection<PriorityItem>(TodoData.PriorityItems);
        Groups = new ObservableCollection<Category>(TodoData.Groups);
    }

    private bool CanLoadDataCommandExecute(object n)
    {
        return true;
    }

    private ICommand removeNoteCommand;
    public ICommand RemoveNoteCommand
            => removeNoteCommand ??= new LambdaCommand(OnRemove, CanRemove);
    public void OnRemove(object p)
    {
        var grop = SelectedGroup;
        grop.Notes.Remove((Note)p);
        SelectedGroup = null;
        SelectedGroup = grop;
    }

    public bool CanRemove(object p) =>
        p is Note note
        && SelectedGroup != null
        && SelectedGroup.Notes.Contains(note);


    private ICommand addNoteCommand;
    public ICommand AddNoteCommand
            => addNoteCommand ??= new LambdaCommand(OnAdd);
    public void OnAdd(object p)
    {
        if (userDialog.CanAdd(SelectedGroup.Notes))
        {
            // Сохранить note в бд
            // Обновить состояние интерфейса
        }
        else
        {
            // nothing
        }
    }

    private ICommand editNoteCommand;
    public ICommand EditNoteCommand
            => editNoteCommand ??= new LambdaCommand(OnEdit);

    public void OnEdit(object p)
    {
        var note = (Note)p;
        if (userDialog.CanEdit(note))
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

