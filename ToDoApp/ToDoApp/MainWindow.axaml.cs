using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ToDoApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddTask_Click(object? sender, RoutedEventArgs e)
    {
        string task = TaskInput.Text.Trim();
        if (!string.IsNullOrEmpty(task))
        {
            TaskList.Items.Add(task);
            TaskInput.Clear();
        }
    }

    private void RemoveTask_Click(object? sender, RoutedEventArgs e)
    {
        if (TaskList.SelectedItem != null)
        {
            TaskList.Items.Remove(TaskList.SelectedItem);
        }
    }
}