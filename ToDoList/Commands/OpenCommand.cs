using System.Windows;

namespace ToDoList.Commands
{
    internal class OpenCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            if (parameter is Window window)
            {
                return window != null;
            }
            return false;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is Window window)
            {
                window.ShowDialog();
            } 
        }
    }
}
