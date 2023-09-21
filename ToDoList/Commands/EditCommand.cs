namespace ToDoList
{
    public class EditCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var editPage = parameter as EditNoteWindow;
            if (editPage is not null)
            {
                var text = editPage.editText.Text;
                if (editPage.MainWindow.noteListView.SelectedItem is not null && !string.IsNullOrEmpty(text))
                {
                    var selectedNote = (Note)editPage.MainWindow.noteListView.SelectedItem;
                    editPage.MainWindow.Notes.Remove(selectedNote);
                    var updatedNote = new Note(text);
                    updatedNote.Id -= 1;
                    editPage.MainWindow.Notes.Add(updatedNote);
                    editPage.Close();
                }
            }
        }
    }
}
