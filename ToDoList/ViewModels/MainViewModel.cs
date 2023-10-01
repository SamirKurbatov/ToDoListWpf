using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ToDoList.BL;
using ToDoList.Domain;

namespace ToDoList;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Note> notes = new();

    [ObservableProperty]
    private Note selectedNote;

    public MainViewModel()
    {
        WeakReferenceMessenger.Default.Register<Note>(this, (r,m) =>
        {
            Notes.Add(m);
        });
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
