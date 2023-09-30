using System.Windows;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для AddNoteWindow.xaml
    /// </summary>
    public partial class AddNoteWindow : Window
    {
        public AddNoteWindow()
        {
            InitializeComponent();
            DataContext = new AddNoteViewModel();
        }
    }
}
