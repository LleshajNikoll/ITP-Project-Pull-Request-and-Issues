using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
namespace Style
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> todos;
        public MainWindow()
        {
            InitializeComponent();
            todos = new ObservableCollection<string>();
            TodoList.ItemsSource = todos;
        }
        private void AddTodo(object sender, RoutedEventArgs e)
        {
            string newTodo = TodoInput.Text.Trim(); 

            if (!string.IsNullOrEmpty(newTodo)) 
            {
                todos.Add(newTodo); 
                TodoInput.Clear();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie ein ToDo ein!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void DeleteTodo(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string todoToDelete = button?.DataContext as string;
            if (todoToDelete != null)
            {
                todos.Remove(todoToDelete);
            }
        }
    }
}
