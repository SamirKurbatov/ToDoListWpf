using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ToDoList.Data;
using ToDoList.Domain;
using ToDoList.Infrastructure.Comparers;
using ToDoList.Infrastructure.Services;

namespace ToDoList;

public partial class MainViewModel : ObservableObject
{
    private IUserDialog userDialog;

    public MainViewModel(IUserDialog userDialog)
    {
        this.userDialog = userDialog;    
    }

    [ObservableProperty]
    private ObservableCollection<Note> notes;

    [ObservableProperty]
    private ObservableCollection<PriorityItem> priorityItems;

    [ObservableProperty]
    private Note selectedNote;

    #region Commands

    [RelayCommand(CanExecute = "CanLoadDataCommandExecute")]
    public void LoadData()
    {
        Notes = new ObservableCollection<Note>(TodoData.Notes);
        PriorityItems = new ObservableCollection<PriorityItem>(TodoData.PriorityItems);
    }
    private bool CanLoadDataCommandExecute()
    {
        return true;
    }

    [RelayCommand]
    public void Remove()
        => Notes.Remove(SelectedNote);

    [RelayCommand]
    public void Add()
    {
        var addNoteWindow = new AddNoteWindow();
        addNoteWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        addNoteWindow.ShowDialog();
    }

    [RelayCommand]
    public void Edit(object p)
    {
        var note = (Note)p;

    }

    [RelayCommand]
    public void OrderByPriority()
    {
        var filtedNotes = Notes.OrderBy(x => x, new PriorityComparer());
        Notes = new ObservableCollection<Note>(filtedNotes);
    }

    [RelayCommand]
    public void OrderByDate()
    {
        var filtedNotes = Notes.OrderByDescending(x => x.Date);
        Notes = new ObservableCollection<Note>(filtedNotes);
    }

    [RelayCommand]
    public void OrderByTitle()
    {
        var filtredNotes = Notes.OrderBy(x => x.Title);
        Notes = new ObservableCollection<Note>(filtredNotes);
    }
    #endregion
}
