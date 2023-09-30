using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ToDoList;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var styles = new List<string> { "Light", "Dark" };
        styleBox.SelectionChanged += ThemeChange;
        styleBox.ItemsSource = styles;
        styleBox.SelectedItem = "Dark";
        this.DataContext = new MainViewModel();
    }

    private void ThemeChange(object sender, SelectionChangedEventArgs e)
    {
        var style = styleBox.SelectedItem as string;
        var uri = new Uri($"./Resources/Themes/{style}.xaml", UriKind.Relative);
        ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
        Application.Current.Resources.Clear();
        Application.Current.Resources.MergedDictionaries.Add(resourceDict);
    }
}
