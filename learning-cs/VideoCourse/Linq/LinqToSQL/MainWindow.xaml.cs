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
            //InsertStudent();
            //InsertLecture();
            //InsertStudentLectureAssociation();
            //GetTonisLectures();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransgenders();
            //GetAllLecturesAtBeijin();
            GetAllStudents();
            UpdateToni();
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
            dataContext.ExecuteCommand("delete from Student");

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

            //MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLecture()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociation()
        {
            // this deletes the current entries to avoid duplicate data
            dataContext.ExecuteCommand("DELETE FROM StudentLecture");

            Student carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            Student leyle = dataContext.Students.First(st => st.Name.Equals("Leyle"));
            Student james = dataContext.Students.First(st => st.Name.Equals("James"));

            Lecture math = dataContext.Lectures.First(l => l.Name.Equals("Math"));
            Lecture history = dataContext.Lectures.First(l => l.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = carla.Id, Lecture = history });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = carla.Id, Lecture = math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = leyle.Id, LectureId = history.Id });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = toni.Id, LectureId = history.Id });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = toni.Id, LectureId = math.Id });

            StudentLecture jamesHistory = new StudentLecture();
            jamesHistory.Student = james;
            jamesHistory.Lecture = history;

            dataContext.SubmitChanges();

            //MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetTonisLectures()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            if (Toni.StudentLectures.Count <= 0)
            {
                MessageBox.Show("User has no lectures");
            }
            else
            {
                var tonisLectures = from sl in Toni.StudentLectures select sl.Lecture;

                MainDataGrid.ItemsSource = tonisLectures;
            }
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromyale = from st in dataContext.Students where st.University.Name == "Yale" select st;

            MainDataGrid.ItemsSource = studentsFromyale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgenderUniversities = from student in dataContext.Students
                                          join university in dataContext.Universities
                                          on student.University equals university
                                          where student.Gender == "trans-gender"
                                          select university;

            MainDataGrid.ItemsSource = transgenderUniversities;
        }

        public void GetAllLecturesAtBeijin()
        {
            var lectures = from stL in dataContext.StudentLectures
                           join student in dataContext.Students
                           on stL.StudentId equals student.Id
                           where student.University.Name == "Beijin tech"
                           select stL.Lecture;

            MainDataGrid.ItemsSource = lectures;

        }

        // update the name of toni
        public void UpdateToni()
        {
            Student toni = dataContext.Students.FirstOrDefault(st => st.Name.Equals("Toni"));

            if (toni != null)
            {
                toni.Name = "Antonio";

                dataContext.SubmitChanges();

                return;
            }

            MessageBox.Show("Student not fount.");
        }

        public void GetAllStudents()
        {
            var students = dataContext.Students;

            MainDataGrid.ItemsSource = students;
        }
    }
}
