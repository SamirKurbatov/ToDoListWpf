using System.Collections.Generic;
using ToDoList.Data;
using System.Windows;
using System.Linq;
using System.Collections.ObjectModel;
using ToDoList.Data.Entities;
using ToDoList.Data.Models;
using ToDoList.Infrastructure.Services.Interfaces;

namespace ToDoList.Infrastructure.Services
{
    internal class AppWindowUserDialogService : IUserDialog
    {
        private readonly IRepository<Category> categoryRepo;

        private readonly IEnumerable<string> priorities;

        public AppWindowUserDialogService(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;

            priorities = new List<string>()
            {
                ePriorityType.Low.ToString(),
                ePriorityType.Medium.ToString(),
                ePriorityType.High.ToString()
            };
        }

        public bool CanCategoryEdit(Category category)
        {
            var viewModel = new EditGroupViewModel(category, categoryRepo.Items);
            var view = new EditGroupNoteWindow { DataContext = viewModel };

            viewModel.ClosedDialog += (s, e) =>
            {
                view.DialogResult = e.Arg;
                view.Close();
            };
            return view.ShowDialog() ?? false;
        }

        public bool CanNoteEdit(Note model)
        {
            var viewModel = new EditNoteViewModel(model, categoryRepo.Items, priorities);
            var view = new EditNoteWindow { DataContext = viewModel };

            viewModel.Complete += (s, e) =>
            {
                view.DialogResult = e.Arg;
                view.Close();
            };
            return view.ShowDialog() ?? false;
        }
    }
}
