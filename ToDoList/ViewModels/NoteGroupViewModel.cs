﻿using System.Collections.ObjectModel;
using ToDoList.Domain;

namespace ToDoList.ViewModels
{
    public class NoteGroupViewModel
    {
        public ObservableCollection<Group> NoteGroups { get; set; } = new()
        {
            new Group("Программирование"),
            new Group("Кулинария")
        };
    }
}
