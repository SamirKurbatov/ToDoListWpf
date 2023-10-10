using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Data;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure.Services;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList;

public class MainViewModel : ViewModel
{
    private IUserDialog userDialog;

    private INotesManager notesManager;

    public MainViewModel(IUserDialog userDialog, INotesManager notesManager)
    {
        this.userDialog = userDialog;
        this.notesManager = notesManager;
    }

    #region Properties

    private ObservableCollection<Category> categories;
    public ObservableCollection<Category> Categories
    {
        get => categories;
        set => Set(ref categories, value);
    }

    private ObservableCollection<string> priorityItems;
    public ObservableCollection<string> PriorityItems
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

    private Category selectedCategory;
    public Category SelectedCategory
    {
        get => selectedCategory;
        set
        {
            Set(ref selectedCategory, value);
        }
    }

    #endregion

    #region Commands

    private ICommand loadDataCommand;

    public ICommand LoadDataCommand
            => loadDataCommand ??= new LambdaCommand(OnLoadData, CanLoadDataCommandExecute);

    public void OnLoadData(object n)
    {
        Categories = new ObservableCollection<Category>(notesManager.CategoriesRepo.Items);
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
        notesManager.Remove((Note)p);
    }

    public bool CanRemove(object p) =>
        p is Note note
        && SelectedCategory != null
        && SelectedCategory.Notes.Contains(note);


    private ICommand editNoteCommand;
    public ICommand EditNoteCommand
            => editNoteCommand ??= new LambdaCommand(OnEdit, _ => SelectedCategory != null);

    public void OnEdit(object p)
    {
        var note = p as Note ?? new Note();
        if (!userDialog.CanEdit(note)) return;

        if (p is null)
        {
            notesManager.NotesRepo.Add(note);
        }
        else
        {
            notesManager.NotesRepo.Update(note);
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

