using System.Collections.Generic;
using ToDoList.Data;
using System.Windows;
using ToDoList.Domain;

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

        public bool Edit(Note model)
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
    }
}
