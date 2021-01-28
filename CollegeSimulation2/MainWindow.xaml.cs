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
using Dapper;

namespace CollegeSimulation2
{

    public partial class MainWindow : Window
    {
        DataAccess dataAccess = new DataAccess();
        public MainWindow()
        {
            InitializeComponent();
            btnStartTheFirstSemester.IsEnabled = false;
        }

        public List<Student> Students { get; set; }

        //load students from SQL database
        private void btnShowStudents_Click(object sender, RoutedEventArgs e)
        {
            
            dgStudentsDataGrid.ItemsSource = dataAccess.LoadStudentList();
            btnStartTheFirstSemester.IsEnabled = true;
        }

        //go to the Semester window
        private void btnStartTheFirstSemester_Click(object sender, RoutedEventArgs e)
        {
            Semester semester = new Semester();
            semester.Show();
            semester.btnNextSemester.IsEnabled = false;
            this.Close();
        }
    }
}
