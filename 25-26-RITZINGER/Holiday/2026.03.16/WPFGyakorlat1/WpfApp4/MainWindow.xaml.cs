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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person { FirstName ="Pista" ,LastName ="Kiss", Age = 26 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(person.FirstName + " " + person.LastName + " is " + person.Age + " year old ");
        }
    }


    //Date storage class
    public class Person
    {

        private string firstnameValue;

        public string FirstName
        {
            get { return firstnameValue; }
            set { firstnameValue = value; }
        }

        private string lastnameValue;

        public string LastName
        {
            get { return lastnameValue; }
            set { lastnameValue = value; }
        }

        private double ageValue;

        public double Age
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