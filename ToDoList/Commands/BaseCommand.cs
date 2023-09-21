using System;
using System.Windows.Input;

namespace ToDoList
{
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged = (sender, obj) => { };

        public abstract bool CanExecute(object? parameter);

        public abstract void Execute(object? parameter);
    }
}
