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

namespace ToDoList
{
    public class NoteViewModel
    {
        #region Propereties
        

        public ObservableCollection<PriorityItem> PriorityOptions { get; set; } = new()
        {
            new PriorityItem(ePriorityType.Low),
            new PriorityItem(ePriorityType.Medium),
            new PriorityItem(ePriorityType.High)
        };

        #endregion
    }
}
