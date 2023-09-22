using System.Windows.Input;

namespace ToDoList
{
    public class CrudCommands
    {
        static CrudCommands()
        {
            AddCommand = new RoutedCommand("AddCommand", typeof(AddCommand));
            RemoveCommand = new RoutedCommand("RemoveCommand", typeof(RemoveCommand));
            EditCommand = new RoutedCommand("EditCommand", typeof(EditCommand));
            OpenCommand = new RoutedCommand("OpenCommand", typeof(ApplicationCommands));
        }

        public static RoutedCommand AddCommand { get; set; }
        public static RoutedCommand RemoveCommand { get; set; }
        public static RoutedCommand EditCommand { get; set; }
        public static RoutedCommand OpenCommand { get; set; }
    }
}
