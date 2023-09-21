using System;

namespace ToDoList
{
    public class RemoveCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var window = parameter as MainWindow;
            if (window is not null)
            {
                if (window.noteListView.SelectedItem != null)
                {
                    var note = (Note)window.noteListView.SelectedItem;
                    window.Notes.Remove(note ?? throw new ArgumentNullException());
                }
            }
        }
    }
}
