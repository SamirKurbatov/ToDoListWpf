namespace ToDoList
{
    public class AddCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            if (parameter is MainWindow window)
            {
                var text = window.noteTextBox.Text;
                
                return window.noteListView.SelectedItem != null || !string.IsNullOrWhiteSpace(text);
            }

            return false;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is MainWindow window)
            {
                if (CanExecute(window))
                {
                    var text = window.noteTextBox.Text;
                    var note = new Note(text);
                    window.Notes.Add(note);
                }
            }
        }
    }
}
