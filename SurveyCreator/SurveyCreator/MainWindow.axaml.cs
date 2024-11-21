using System.Collections.ObjectModel;
using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SurveyCreator;

public partial class MainWindow : Window
{
    private ObservableCollection<string> questions { get; set; } = new ObservableCollection<string>();
    public MainWindow()
    {
        InitializeComponent();
        
        QuestionsListBox.ItemsSource = questions;

        AddAnswerButton.Click += AddAnswerButton_Click;
        SaveButton.Click += SaveButton_Click;
    }

    private void AddAnswerButton_Click(object sender, RoutedEventArgs e)
    {
        var question = QuestionTextBox.Text;
        var answer = AnswerTextBox.Text;

        if (!string.IsNullOrWhiteSpace(question) && !string.IsNullOrWhiteSpace(answer))
        {
            questions.Add($"{question}? {answer}");
            AnswerTextBox.Clear();
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        var filePath = "ankieta.txt";
        File.WriteAllLines(filePath, questions);
    }
}