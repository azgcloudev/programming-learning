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

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSQLDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.PanjutorialsDBConnectionString"].ConnectionString;
            dataContext = new LinqToSQLDataClassesDataContext(connectionString);

            // InsertUniversity();
            InsertStudent();
        }

        // insert a university into a table
        public void InsertUniversity()
        {
            // delete first everything in the University table
            dataContext.ExecuteCommand("DELETE FROM University");

            University yale = new University();
            University beijinTech = new University();

            yale.Name = "Yale";
            beijinTech.Name = "Beijin Tech";

            dataContext.Universities.InsertOnSubmit(yale);
            dataContext.Universities.InsertOnSubmit(beijinTech);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University yale = dataContext.Universities.First(um => um.Name.Equals("Yale"));
            University beijinTech = dataContext.Universities.First(um => um.Name.Equals("Beijin Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Toni", Gender = "male", University = yale });
            students.Add(new Student { Name = "Leyle", Gender = "female", University = beijinTech });
            students.Add(new Student { Name = "James", Gender = "male", University = beijinTech });

            dataContext.Students.InsertAllOnSubmit(students);

            // submit the changes
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
