using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SurveyCreator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddAnswerButton_Click(object sender, RoutedEventArgs e)
    {
        var question = QuestionTextBox.Text;
        var answer = AnswerTextBox.Text;

        if (!string.IsNullOrWhiteSpace(question) && !string.IsNullOrWhiteSpace(answer))
        {
            QuestionsListBox.Items.Add($"{question}? {answer}");
            AnswerTextBox.Clear();
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        var filePath = "ankieta.txt";
        var items = QuestionsListBox.Items.Cast<string>();
        File.WriteAllLines(filePath, items);
    }
}