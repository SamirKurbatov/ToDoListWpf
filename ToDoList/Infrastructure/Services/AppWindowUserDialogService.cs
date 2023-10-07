using System.Collections.Generic;
using ToDoList.Data;
using System.Windows;
using System.Linq;
using System.Collections.ObjectModel;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;

namespace ToDoList.Infrastructure.Services
{
    internal class AppWindowUserDialogService : IUserDialog
    {
        private IEnumerable<Note> notes;

        private IEnumerable<PriorityItem> priorityItems;

        public AppWindowUserDialogService(/* репозиторий групп */)
        {
            priorityItems = new ObservableCollection<PriorityItem>()
            {
                new PriorityItem(ePriorityType.Low),
                new PriorityItem(ePriorityType.Medium),
                new PriorityItem(ePriorityType.High)
            };

            notes = new ObservableCollection<Note>();
        }

        public bool CanEdit(Note model)
        {
            var viewModel = new EditViewModel(model, notes, priorityItems);
            var view = new EditNoteWindow
            {
                DataContext = viewModel,
                Owner = App.CurrentWindow,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            viewModel.Complete += (s, e) =>
            {
                view.DialogResult = e.Arg;
                view.Close();
            };
            return view.ShowDialog() ?? false;
        }


        public bool CanAdd(ICollection<Note> notes)
        {
            var viewModel = new AddNoteViewModel(notes, priorityItems);

            var view = new AddNoteWindow()
            {
                DataContext = viewModel,
                Owner = App.CurrentWindow,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            viewModel.Complete += (s, e)
                =>
            {
                view.DialogResult = e.Arg;
                view.Close();
            };

            return view.ShowDialog() ?? false;
        }
    }
}
