using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;
using ToDoList.BL;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для EditNoteWindow.xaml
    /// </summary>
    public partial class EditNoteWindow : Window
    {
        public NoteViewModel NoteViewModel { get; set; } 

        public Note EditNode { get; set; }

        public EditNoteWindow(NoteViewModel noteViewModel)
        {
            InitializeComponent();
            EditNode = new();
            NoteViewModel = noteViewModel;
            DataContext = this;
        }

        public ICommand SaveCommand => new RelayCommand(() =>
        {
            EditNode.Priority = NoteViewModel.SelectedPriority;
            EditNode.Title = editText.Text;
            DialogResult = true;
        });

        private void CancelWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
    }
}
