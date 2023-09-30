using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ToDoList.Domain;

namespace ToDoList;

public partial class AddNoteViewModel : ObservableObject
{
    #region Properties
    [ObservableProperty]
    private Note mainNote = new();

    public PriorityItem SelectedPriority { set; get; }

    #endregion

    private ObservableCollection<Note> notes;

    public AddNoteViewModel()
    {
        notes = NotesRepository.Instance.Notes;
    }

    [RelayCommand]
    public void Add()
    {
        var title = MainNote.Title;
        if (!string.IsNullOrWhiteSpace(title))
        {
            notes.Add(new Note(title));
            MainNote.Title = "";
        }
        else
        {
            MessageBox.Show("Проверьте все поля!");
        }
    }
}

public class NotesRepository
{
    private static NotesRepository instance;

    private ObservableCollection<Note> notes = new();

    public static NotesRepository Instance 
        => instance ?? (instance = new NotesRepository());

    public ObservableCollection<Note> Notes
        => notes;
}
