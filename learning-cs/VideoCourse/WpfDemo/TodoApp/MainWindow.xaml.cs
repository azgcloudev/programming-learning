using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // function the react to the add todo button
        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = InputBox.Text;

            // check if the input is empty
            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White)
                };

                // Adds the todo item to the StackPanel
                TodoTextStack.Children.Add(todoItem);

                // clear the text in the input box
                InputBox.Clear();
            }
        }
    }
}