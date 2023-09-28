using ToDoList.ViewModels;

namespace ToDoList.BL
{
    public class BLogical
    {
        public NoteViewModel NoteViewModel { set; get; }

        public NoteGroupViewModel NoteGroupViewModel { set; get; }

        public BLogical()
        {
            NoteViewModel = new();
            NoteGroupViewModel = new();
        }
    }
}
