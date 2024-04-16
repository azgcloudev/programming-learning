using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPFZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create a sql connection
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["WPFZooManager.Properties.Settings.PanjutorialsDBConnectionString"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            ShowZoos();
        }

        private void ShowZoos()
        {

            try
            {
                string query = "SELECT * FROM Zoo";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlAdapter.Fill(zooTable);

                    // Which information of the Table in DataTable should be shwn in the ListBox
                    ListZoos.DisplayMemberPath = "Location";

                    // Which Value should be delievered, when an Item from the ListBox is Selected
                    ListZoos.SelectedValuePath = "id";

                    // The reference to the Data the ListBox should populate
                    ListZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            // Catch any exception and display it in a Message Box
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ShowAssociatedAnimals()
        {

            try
            {
                string query = "SELECT * FROM Animal a inner join ZooAnimal za on a.Id = za.AnimalId where za.ZooId = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlAdapter)
                {
                    // adds a value to the parameter given in the SQL query
                    sqlCommand.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);

                    DataTable animalTable = new DataTable();
                    sqlAdapter.Fill(animalTable);

                    // Which information of the Table in DataTable should be shwn in the ListBox
                    AnimalsInZooList.DisplayMemberPath = "Name";

                    // Which Value should be delievered, when an Item from the ListBox is Selected
                    AnimalsInZooList.SelectedValuePath = "Id";

                    // The reference to the Data the ListBox should populate
                    AnimalsInZooList.ItemsSource = animalTable.DefaultView;

                }
            }
            // Catch any exception and display it in a Message Box
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.ToString());
            }

        }

        private void ListZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
        }
    }
}
