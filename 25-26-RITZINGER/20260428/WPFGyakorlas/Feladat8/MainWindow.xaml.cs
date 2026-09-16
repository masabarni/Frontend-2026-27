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

namespace Feladat8
{

    public class Termek
    {
        public string Nev { get; set; }
        public int Ar { get; set; }
    }

    public partial class MainWindow : Window
    {
        private List<Termek> _termekek = new List<Termek>();

        public MainWindow()
        {
            InitializeComponent();

            dgTermekek.ItemsSource = _termekek;
        }

        private void TermekHozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTermekNev.Text) &&
                int.TryParse(txtAr.Text, out int ar))
            {
                Termek ujTermek = new Termek
                {
                    Nev = txtTermekNev.Text,
                    Ar = ar
                };

                _termekek.Add(ujTermek);

                dgTermekek.Items.Refresh();

                txtTermekNev.Clear();
                txtAr.Clear();
            }
            else
            {
                MessageBox.Show("Kérlek, adj meg egy nevet és egy érvényes számot!");
            }
        }

        private void TermekTorol_Click(object sender, RoutedEventArgs e)
        {
            if (dgTermekek.SelectedItem != null)
            {
                Termek kijelolt = (Termek)dgTermekek.SelectedItem;

                _termekek.Remove(kijelolt);

                dgTermekek.Items.Refresh();
            }
        }
    }
}