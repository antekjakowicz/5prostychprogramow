using Avalonia.Controls;
using Avalonia.Interactivity;

namespace EventCalendar;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddEventClicked(object? sender, RoutedEventArgs e)
    {
        var eventName = EventNameTextBox.Text;
        
        var selectedItem = DayComboBox.SelectedItem as ComboBoxItem;
        var day = selectedItem?.Content?.ToString();
        
        var isImportant = ImportantCheckBox.IsChecked.Value;

        if (!string.IsNullOrWhiteSpace(eventName) && !string.IsNullOrEmpty(day))
        {
            var newEvent = $"{day}: {eventName}";

            if (isImportant)
            {
                newEvent += " (ważne)";
            }
            
            EventListBox.Items.Add(newEvent);
        }
    }
}