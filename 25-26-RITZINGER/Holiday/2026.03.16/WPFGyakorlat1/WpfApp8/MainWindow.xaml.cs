using System.Collections.ObjectModel;
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

namespace WpfApp8
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }

        public bool Married { get; set; }
    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Employees = new ObservableCollection<Employee>
            {
                new Employee {Name = "Kovács János",Position = "Fejlesztő",Salary = "400000",  Married = true},
                new Employee {Name = "Nagy Mária",Position = "Tesztelő",Salary = "300000", Married = false}
            };

                DataContext = this;

            //Dinamikus 
            AddEmployee_Click(null, null);//Gomb esemény
        }
        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            //Employees.Add(new Employee { Name = "Új Dolgozó", Position = "Admin" });
            DataInput inputablak = new DataInput();
            inputablak.Show();
        }

        private void Employee_Delete(object sender, RoutedEventArgs e)
        {
            Employees.RemoveAt(dataGrid.SelectedIndex);
        }

        private void Employee_Edit(object sender, RoutedEventArgs e)
        {

        }
    }
}