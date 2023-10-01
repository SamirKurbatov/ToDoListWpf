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

    public ObservableCollection<PriorityItem> PriorityOptions { get; set; } = new()
    {
        new PriorityItem(ePriorityType.Low),
        new PriorityItem(ePriorityType.Medium),
        new PriorityItem(ePriorityType.High)
    };

    #endregion

    [RelayCommand]
    public void Add()
    {
        var title = mainNote.Title;
        var priority = SelectedPriority;
        if (!string.IsNullOrWhiteSpace(title) && SelectedPriority is not null)
        {
            WeakReferenceMessenger.Default.Send(new Note(title, priority));
        }
        else
        {
            MessageBox.Show("Проверьте значение полей! ");
        }
    }
}
