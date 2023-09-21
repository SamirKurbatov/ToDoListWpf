namespace ToDoList
{
    public class AddCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            if (parameter is MainWindow window)
            {
                return window.noteListView.SelectedItem != null;
            }
            return false;
        }

        public override void Execute(object? parameter)
        {
            var id = 0;
            if (parameter is MainWindow window)
            {
                var text = window.noteTextBox.Text;
                var note = new Note(text);
                window.Notes.Add(note);
                id++;
            }
        }
    }
}
