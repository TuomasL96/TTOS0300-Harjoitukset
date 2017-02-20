using MVVMDemo.Model;
using System.Collections.ObjectModel;

namespace MVVMDemo.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            //lisään esimerkin vuoksi muutama opiskelija, oikeassa sovelluksessa haettaisiin esim tietokannasta
            students.Add(new Student { FirstName = "Mark", LastName = "Allen" });
            students.Add(new Student { FirstName = "John", LastName = "Doe" });
            students.Add(new Student { FirstName = "Linda", LastName = "Kernell" });
            Students = students;
        }
    }
}
