using System.Windows;
namespace WPFDataBinding
{

    public partial class MainWindow : Window
    {

        // code bihind databinding-hoz kell
        //Person person = new Person { Names = "Salman", Ages = 26 };

        public MainWindow()
        {
            InitializeComponent();
            // code bihind databinding-hoz kell
            //this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // code bihind databinding-hoz ez nem kell
            Person person = (Person)DataContext;
            string message = person.Names + " is " + person.Ages;
            MessageBox.Show(message);
        }
    }

    public class Person
    {

        private string nameValue;

        public string Names
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        private double ageValue;

        public double Ages
        {
            get { return ageValue; }

            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }
        }

    }
}
