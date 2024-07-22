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
using DataBinding.Data;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Person person = new Person
        {
            Name = "Luca",
            Age = 26,
        };

        public MainWindow()
        {
            InitializeComponent();

            // links the object in the current window with the UI elements
            this.DataContext = person;
        }

        // Info button click
        private void ButtonInfo_Clicked(object sender, RoutedEventArgs e)
        {
            string personData = person.Name + " is " + person.Age + " years old.";
            MessageBox.Show(personData);
        }
    }
}