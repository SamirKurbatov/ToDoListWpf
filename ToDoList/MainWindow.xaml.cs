using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ToDoList.Commands;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Note> Notes { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Notes = new ObservableCollection<Note>();
            noteListView.ItemsSource = Notes;
        }

        private void AddCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var command = new AddCommand();
            command.Execute(this);
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var command = new OpenCommand();
            var editPage = new EditNoteWindow(this);
            command.Execute(editPage);
        }

        private void RemoveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var command = new RemoveCommand();
            command.Execute(this);
        }
    }
}
