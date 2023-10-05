using System.Collections.Generic;
using ToDoList.Data;
using System.Windows;
using ToDoList.Domain;
using System.Linq;
using System.Collections.ObjectModel;

namespace ToDoList.Infrastructure.Services
{
    internal class AppWindowUserDialogService : IUserDialog
    {
        private IEnumerable<Note> notes;

        private IEnumerable<PriorityItem> priorityItems;

        public AppWindowUserDialogService(/* репозиторий групп */)
        {
            notes = TodoData.Notes;
            priorityItems = TodoData.PriorityItems;
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
