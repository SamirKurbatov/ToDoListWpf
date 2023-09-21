using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var command = new RemoveCommand();
            command.Execute(this);
          
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            var command = ApplicationCommands.Open;
            command.Execute(new EditNoteWindow(this), this);
        }

        private void AddCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var command = new AddCommand();
            command.Execute(this);
        }
    }

    public class Note
    {
        private static int nextId = 1;

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Note(string title)
        {
            Id = nextId++;
            Title = title;
            Date = DateTime.Now;
        }
    }

    record Person(string Name, string Job)
    {
        public override string ToString()
        {
            return $"{Name}({Job})";
        }
    }
}
