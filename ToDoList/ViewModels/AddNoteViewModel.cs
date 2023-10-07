using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Data;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure;

namespace ToDoList
{
    public class AddNoteViewModel : ViewModel
    {
        public event EventHandler<EventArgs<bool>> Complete;

        #region Properties

        public string Title { get; set; }

        public PriorityItem PriorityItem { get; set; }

        public ICollection<Note> Notes { get; set; }

        public IEnumerable<PriorityItem> PriorityItems { get; set; }

        #endregion

        public AddNoteViewModel() : this(default, Enumerable.Empty<PriorityItem>()) { }

        public AddNoteViewModel(ICollection<Note> notes, IEnumerable<PriorityItem> priorityItems)
        {
            Notes = notes;
            PriorityItems = priorityItems;
        }

        #region Commands

        private ICommand addCommand;
        public ICommand AddCommand
            => addCommand ??= addCommand = new LambdaCommand(OnAdd, CanAdd);

        public void OnAdd(object n)
        {
            var note = new Note();
            Notes.Add(note);
            Complete?.Invoke(this, true);
        }

        public bool CanAdd(object n)
            => true;

        public ICommand cancelCommand;
        public ICommand CancelCommand
            => cancelCommand ??= new LambdaCommand(OnCancel);

        public void OnCancel(object n)
        {
            Complete?.Invoke(this, false);
        }

        #endregion

    }
}
