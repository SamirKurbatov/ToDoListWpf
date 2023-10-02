using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDoList.Domain;

namespace ToDoList;

public partial class EditViewModel
{
    public Note EditNote { get; set; } = new();

    public PriorityData PriorityData { get; set; } = new();

    public PriorityItem PriorityItem { get; set; }

    public EditViewModel()
    {
        
    }

    [RelayCommand(CanExecute = "CanAgree")]
    public void Agree()
    {
        var newTitle = EditNote.Title;
        var newPriority = PriorityItem;

    }

    [RelayCommand]
    public void Cancel(object obj)
    {
        var window = obj as EditNoteWindow;
        if (window != null)
        {
            window.Close();
        }
    }

    private bool CanAgree()
    {
        if (PriorityData != null || !string.IsNullOrWhiteSpace(EditNote.Title))
        {
            return true;
        }
        return false;
    }
}
