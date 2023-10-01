using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
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

    [RelayCommand]
    public void Add()
    {
        var title = MainNote.Title;
        WeakReferenceMessenger.Default.Send(new Note(title));
    }
}
