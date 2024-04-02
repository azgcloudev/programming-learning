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

namespace ListBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Person> people = new List<Person>()
        {
            new Person{Name = "Josh", Age = 28},
            new Person{Name = "Ana", Age = 21},
            new Person{Name = "Jorge", Age = 31}
        };

        public MainWindow()
        {
            InitializeComponent();

            // add items to the ListBox
            ListBoxPeople.ItemsSource = people;
        }

        private void ButtonShowItems(object sender, RoutedEventArgs e)
        {
            // get the items selected
            var items = ListBoxPeople.SelectedItems;

            foreach (var item in items)
            {
                // cast the object item to Person
                Person person = (Person)item;

                // display a message box with the name
                MessageBox.Show(person.Name);
            }
        }
    }
}