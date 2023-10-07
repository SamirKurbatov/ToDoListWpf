using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Data;
using ToDoList.Domain;
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

    private ObservableCollection<Note> notes;
    public ObservableCollection<Note> Notes
    {
        get => notes;
        set => Set(ref notes, value);
    }

    private ObservableCollection<Group> groups;
    public ObservableCollection<Group> Groups
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


    private Group selectedGroup;
    public Group SelectedGroup
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
        Notes = new ObservableCollection<Note>(TodoData.Notes);
        PriorityItems = new ObservableCollection<PriorityItem>(TodoData.PriorityItems);
        Groups = new ObservableCollection<Group>(TodoData.GroupNotes);
    }

    private bool CanLoadDataCommandExecute(object n)
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
        if (userDialog.CanAdd(Notes))
        {
            // Сохранить note в бд
            // Обновить состояние интерфейса
        }
        else
        {
            // nothing
        }
    }

    private ICommand editCommand;
    public ICommand EditCommand
            => editCommand ??= new LambdaCommand(OnEdit);

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
