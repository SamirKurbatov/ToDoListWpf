using System;
using System.Linq;
using System.Windows.Controls;

namespace ToDoList
{
    public class RemoveCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            if (parameter is MainWindow window && window is not null)
            {
                return window.noteListView.Items.Count > 0;
            }
            return true;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is MainWindow window && window is not null)
            {
                if (window.noteListView.SelectedItem is not null)
                {
                    var note = (Note)window.noteListView.SelectedItem;
                    window.Notes.Remove(note ?? throw new ArgumentNullException());
                }
            }
        }
    }
}
