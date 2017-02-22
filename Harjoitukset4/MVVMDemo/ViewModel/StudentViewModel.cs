using MVVMDemo.Model;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;

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
            students.Add(new Student { FirstName = "Mark", LastName = "Allen" });
            students.Add(new Student { FirstName = "John", LastName = "Doe" });
            students.Add(new Student { FirstName = "Linda", LastName = "Kernell" });
            Students = students;
        }
        private string GetMysqlConnectionString()
        {
            string pw = ""; 
            // haetaan salasana app.config konfiguraatiotiedostosta
            //pw = MVVMDemo.Properties.Settings.Default.Password;
            return string.Format("Data source=mysql.labranet.jamk.fi;Initial Catalog=K2679_2;user=K2679;password={0}", pw);
        }
        public void LoadStudentsFromMysql()
        {
            try
            {
                ObservableCollection<Student> students = new ObservableCollection<Student>();
                //luodaan yhteys labranetin mysql-palvelimelle
                string connStr = GetMysqlConnectionString();
                string sql = "SELECT firstname, lastname, asioid FROM student";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MVVMDemo.Model.Student s = new Model.Student();
                            s.FirstName = reader.GetString(0);
                            s.LastName = reader.GetString(1);
                            students.Add(s);
                        }
                        Students = students;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
