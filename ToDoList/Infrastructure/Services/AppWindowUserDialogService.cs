using System.Collections.Generic;
using ToDoList.Data;
using System.Windows;

namespace ToDoList.Infrastructure.Services
{
    internal class AppWindowUserDialogService : IUserDialog
    {
        private IEnumerable<Note> notes;

        public AppWindowUserDialogService(/* репозиторий групп */)
        {
            notes = TodoData.Notes;
        }

        public bool Edit(Note model)
        {
            var viewModel = new EditViewModel(model, notes);
            var view = new EditNoteWindow
            {
                DataContext = viewModel,
                Owner = App.CurrentWindow,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            return view.ShowDialog() ?? false;
        }
    }
}
