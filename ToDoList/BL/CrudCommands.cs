using CommunityToolkit.Mvvm.Input;

namespace ToDoList.BL
{
    public class CrudCommands
    {
        public RelayCommand AddCommand { get; set; }

        public RelayCommand RemoveCommand { get; set; }

        public RelayCommand OpenCommand { get; set; }
    }

}
