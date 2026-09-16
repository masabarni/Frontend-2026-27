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

namespace Feladat6
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

        private void InfoFrissit()
        {
            int db = lstFeladatok.Items.Count;
            txtInfo.Text = $"{db} feladat van még";
        }

        private void Hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUjFeladat.Text))
            {
                lstFeladatok.Items.Add(txtUjFeladat.Text);

                txtUjFeladat.Clear();

                InfoFrissit();
            }
        }

        private void Torol_Click(object sender, RoutedEventArgs e)
        {
            if (lstFeladatok.SelectedItem != null)
            {
                lstFeladatok.Items.Remove(lstFeladatok.SelectedItem);
                InfoFrissit();
            }
            else
            {
                txtInfo.Text = "Nincs kijelölt elem!";
            }
        }

        private void Kesz_Click(object sender, RoutedEventArgs e)
        {
            if (lstFeladatok.SelectedItem != null)
            {
                int index = lstFeladatok.SelectedIndex;
                string eredetiSzoveg = lstFeladatok.SelectedItem.ToString();

                if (!eredetiSzoveg.StartsWith("✓ "))
                {
                    lstFeladatok.Items[index] = "✓ " + eredetiSzoveg;
                }

                InfoFrissit();
            }
            else
            {
                txtInfo.Text = "Nincs kijelölt elem!";
            }
        }
    }
}