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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Student s;
            s = new Student();
            s.StudentId = 0;
            s.Name = "Matt";

            this.DataContext = s;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Student).Save(); 
        }

        private void GradeButton_Click(object sender, RoutedEventArgs e)
        {
            TeacherUtils tu = new TeacherUtils();
            
            
                float x = float.Parse(this.studentScore.Text);
            System.Diagnostics.EventLog.WriteEntry("GradeApp", "Grading the student"
                , System.Diagnostics.EventLogEntryType.Information);

            float z = float.Parse(this.curve.Text);

            string y = tu.GetGrade(score: x, curve: z);
            this.letterGrade.Text = y;
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //create another info window
            //InfoWindow w = new InfoWindow();
            //w.Show();
            TeacherUtils ut = new TeacherUtils();
            string dn = "";
            bool x = ut.IsWorkday(out dn);
            this.letterGrade.Text = dn;

        }
    }
}
