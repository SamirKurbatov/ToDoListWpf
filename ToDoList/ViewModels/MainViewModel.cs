using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ToDoList.Data;
using ToDoList.Domain;
using ToDoList.Infrastructure.Comparers;

namespace ToDoList;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Note> notes;

    [ObservableProperty]
    private ObservableCollection<PriorityItem> priorityItems;

    [ObservableProperty]
    private Note selectedNote;

    private ICommand loadDataCommand;
    public ICommand LoadDataCommand
        => loadDataCommand ??= new RelayCommand(OnLoadData, CanLoadDataCommandExecute);

    public void OnLoadData()
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
    {
        if (SelectedNote != null)
        {
            Notes.Remove(SelectedNote);
        }
        else
        {
            MessageBox.Show("Элемент не выбран! ");
        }
    }

    [RelayCommand]
    public void ShowAddWindow()
    {
        var addNoteWindow = new AddNoteWindow();
        addNoteWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        addNoteWindow.ShowDialog();
    }

    [RelayCommand]
    public void ShowEditWindow()
    {
        var editNote = new EditNoteWindow();
        editNote.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        editNote.ShowDialog();

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
}
