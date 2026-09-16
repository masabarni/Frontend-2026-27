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

namespace Feladat7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool _frissites = false;

        private void Celsius_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txtFahrenheit == null) return;

            if (_frissites) return;

            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                _frissites = true;
                double fahrenheit = celsius * 9 / 5 + 32;

                // Itt már biztosan nem fog elszállni
                txtFahrenheit.Text = fahrenheit.ToString("0.##");

                FrissitLeiras(celsius);
                _frissites = false;
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            txtCelsius.Text = Math.Round(e.NewValue).ToString();
        }

        private void FrissitLeiras(double fok)
        {
            if (fok < 0)
                txtLeiras.Text = "Fagyos";
            else if (fok <= 20)
                txtLeiras.Text = "Hűvös";
            else if (fok <= 30)
                txtLeiras.Text = "Kellemes";
            else
                txtLeiras.Text = "Meleg";
        }
    }
}