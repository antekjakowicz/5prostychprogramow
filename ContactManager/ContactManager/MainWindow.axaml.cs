using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ContactManager;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

    }

    private void BtnAddContact_OnClick(object? sender, RoutedEventArgs e)
    {
        string con1 = Email.Text.Trim(),
            con2 = Fname.Text.Trim(),
            con3 = Lname.Text.Trim(),
            con4 = Phone.Text.Trim();
            var fav1 = Fav.IsChecked.Value;
            //var selectedItem = cmbFilter.SelectedItem as ComboBoxItem;
        
        if (!string.IsNullOrEmpty(con1) && !string.IsNullOrEmpty(con2) && !string.IsNullOrEmpty(con3) &&
            !string.IsNullOrEmpty(con4))
        {
            
            string formattedContact = $"| Imie: {con2} {con3} | Numer Telefonu: {con4} | Email: {con1} |";
            
            if (fav1 == true)
            {
                formattedContact += " ʕ•́ᴥ•̀ʔっ |";
            }
            else
            {
                formattedContact += " ------- |";
            }

            lcon.Items.Add(formattedContact);
            
            Fname.Clear();
            Lname.Clear();
            Phone.Clear();
            Email.Clear();


        }
        
    }
    
    
    private void BtnDeleteContact_OnClick(object? sender, RoutedEventArgs e)
    {
        if (lcon.SelectedItem != null)
        {
            lcon.Items.Remove(lcon.SelectedItem);
        }
    }
}


   