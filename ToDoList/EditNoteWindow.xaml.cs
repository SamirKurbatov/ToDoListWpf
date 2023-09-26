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
        public Note EditNode { get; set; }
        public EditNoteWindow()
        {
            InitializeComponent();
            EditNode = new();
            DataContext = this;
        }

        public ICommand SaveCommand => new RelayCommand(() =>
        {
            EditNode.Title = editText.Text;
            DialogResult = true;
        });

        private void CancelWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
    }
}
