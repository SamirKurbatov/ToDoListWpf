using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для EditNoteWindow.xaml
    /// </summary>
    public partial class EditNoteWindow : Window
    {
        public MainWindow MainWindow { get;}

        public EditNoteWindow(MainWindow main)
        {
            InitializeComponent();
            MainWindow = main;
        }

        private void CancelWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AgreeButton_Click(object sender, RoutedEventArgs e)
        {
            var editCommand = new EditCommand();
            editCommand.Execute(this);
        }
    }
}
