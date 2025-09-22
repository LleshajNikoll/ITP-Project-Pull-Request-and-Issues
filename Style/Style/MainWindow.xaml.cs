using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Style
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddTodo(object sender, RoutedEventArgs e)
        {
            string task = TodoInput.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                TodoList.Items.Add(task);
                TodoInput.Clear();
            }
            else
            {
                MessageBox.Show("Bitte eine Aufgabe eingeben!", "Hinweis",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void DeleteTodo(object sender, RoutedEventArgs e)
        {
            Button deleteButton = sender as Button;
            if (deleteButton != null)
            {
                string task = (deleteButton.DataContext as string);
                if (task != null && TodoList.Items.Contains(task))
                {
                    TodoList.Items.Remove(task);
                }
            }
        }

        // ✅ Aufgabe als erledigt markieren
        private void TaskChecked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                checkBox.Foreground = Brushes.Gray;
                checkBox.TextDecorations = TextDecorations.Strikethrough;
            }
        }

        // ❌ Erledigt-Markierung entfernen
        private void TaskUnchecked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                checkBox.Foreground = Brushes.Black;
                checkBox.TextDecorations = null;
            }
        }
    }
}
