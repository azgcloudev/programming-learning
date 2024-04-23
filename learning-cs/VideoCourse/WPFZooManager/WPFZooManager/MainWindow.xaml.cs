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
            ShowAnimals();
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

                    // Which information of the Table in DataTable should be shown in the ListBox
                    ListZoos.DisplayMemberPath = "Location";

                    // Which Value should be delievered, when an Item from the ListBox is Selected
                    ListZoos.SelectedValuePath = "Id";

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

        /// <summary>
        /// Shows the animals associated to a Zoo.
        /// </summary>
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

        // Displays the list of the animals
        private void ShowAnimals()
        {
            string query = "SELECT * FROM Animal";

            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlAdapter)
                {

                    DataTable animalsTable = new DataTable();
                    sqlAdapter.Fill(animalsTable);

                    AnimalsListBox.DisplayMemberPath = "Name";

                    AnimalsListBox.SelectedValuePath = "Id";

                    AnimalsListBox.ItemsSource = animalsTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}.\nException: {ex.InnerException.ToString()}");
            }
        }

        // Action buttons below
        /// <summary>
        /// DeleteZoo_Click will delete the Zoo item that is selected in the List Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            string query = "DELETE FROM ZOO WHERE id = @ZooId";

            SqlCommand sqlCmd = new SqlCommand(query, sqlConnection);

            try
            {
                //open a connection
                sqlConnection.Open();

                // add parameters to the command
                sqlCmd.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);

                // execute the query
                sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {0}", ex.Message);
            }
            finally
            {
                // close sql connection
                sqlConnection.Close();
                ShowZoos(); // run again the query to get the new list of zoos
            }
        }

        // add a new Zoo
        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO Zoo VALUES (@Location)";

            SqlCommand sqlCmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCmd.Parameters.AddWithValue("@Location", inputTextBox.Text);
                // execute query
                sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                sqlConnection.Close();
                ShowZoos();
            }
        }

        // add a new animal to a Zoo
        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO ZooAnimal VALUES (@ZooId, @AnimalId)";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {

                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("ZooId", int.Parse(ListZoos.SelectedValue.ToString()));
                sqlCommand.Parameters.AddWithValue("AnimalId", int.Parse(AnimalsListBox.SelectedValue.ToString()));
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }

        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO Animal VALUES (@Name)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", inputTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inputTextBox.Clear(); // cleans the input field
                sqlConnection.Close();
                ShowAnimals();
            }
        }

        /// <summary>
        /// Removes an animal from the animal list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            string query = "DELETE FROM Animal WHERE Id = @AnimalId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", AnimalsListBox.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimals();
            }
        }

        /// <summary>
        /// Removes an animal from a selected Zoo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAnimalFromZoo_Click(object sender, RoutedEventArgs e)
        {
            string query = "DELETE FROM ZooAnimal WHERE Id = @Id";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            DataRowView item = (DataRowView)AnimalsInZooList.SelectedItem;
            int itemId = int.Parse(item.Row.ItemArray[2].ToString());

            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Id", itemId);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }
    }
}
