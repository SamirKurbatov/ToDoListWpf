using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ToDoList.BL;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new BLogical();
        }
    }
}
