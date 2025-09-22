using System.Windows;
using System.Windows.Controls;

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
    }
}
