using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ToDoList.BL;
using ToDoList.Domain;

namespace ToDoList;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        generalNotes = NotesRepository.Instance.Notes;
    }

    [ObservableProperty]
    private ObservableCollection<Note> generalNotes;

    [ObservableProperty]
    private ObservableCollection<Note> filtredNotes;

    [ObservableProperty]
    private Note selectedNote;

    [RelayCommand]
    public void Remove()
    {
        if (SelectedNote != null)
        {
            GeneralNotes.Remove(SelectedNote);
        }
        else
        {
            MessageBox.Show("Элемент не выбран! ");
        }
    }

    [RelayCommand]
    public void ShowWindow(object obj) // Добавить CommandParametr
    {
        var mainWindow = obj as Window;

        var addUserWindow = new AddNoteWindow();
        addUserWindow.Owner = mainWindow;
        addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        addUserWindow.ShowDialog();
    }

    [RelayCommand]
    public void OrderByPriority()
    {
        FiltredNotes = new ObservableCollection<Note>(generalNotes
                   .OrderBy((x => x), new PriorityComparer()));
    }

    [RelayCommand]
    public void OrderByDate()
    {
        FiltredNotes = new ObservableCollection<Note>(GeneralNotes
            .OrderByDescending(x => x.Date));
    }

    [RelayCommand]
    public void OrderByTitle()
    {
        FiltredNotes = new ObservableCollection<Note>(GeneralNotes
            .OrderBy(x => x.Title));
    }
}
