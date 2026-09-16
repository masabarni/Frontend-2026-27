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

namespace Feladat3
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

        private void Osszead_Click(object sender, RoutedEventArgs e)
        {
            int szamA, szamB;

            bool sikerA = int.TryParse(txtA.Text, out szamA);
            bool sikerB = int.TryParse(txtB.Text, out szamB);

            if(sikerA && sikerB)
            {
                int osszeg = szamA + szamB;
                txtEredmeny.Text = $"Eredmeny:{osszeg}";
            }
            else
            {
                txtEredmeny.Text = "Kérlek adj meg két érvényes számot!";
            }
        }
    }
}