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

namespace Feladat5
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

        private void OsszegFrissit()
        {
            int alap = 5000;

            int szallitas = 0;
            if (rbGyors.IsChecked == true) szallitas = 990;
            if (rbExpressz.IsChecked == true) szallitas = 19990;

            int fizites = cbFizetes?.SelectedIndex == 1 ? 350 : 0;

            int osszeg = alap + szallitas + fizites;
            txtOsszeg.Text = $"Fizetendő: {osszeg} Ft.";
        }

        private void Szallitas_Checked(object sender, RoutedEventArgs e)
        {
            OsszegFrissit();
        }

        private void Fizetes_Changed(object sender, SelectionChangedEventArgs e)
        {
            if(txtOsszeg ==  null) return;
            OsszegFrissit();
        }
    }
}