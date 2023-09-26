using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ToDoList.Domain;

namespace ToDoList.BL
{
    public class BLogical
    {
        public NoteViewModel NoteViewModel { set; get; }

        public BLogical()
        {
            NoteViewModel = new();
        }
    }
}
