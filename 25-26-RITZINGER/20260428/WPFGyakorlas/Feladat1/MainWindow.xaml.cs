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

namespace Feladat1
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

        private void Udvozol_Click(object sender, RoutedEventArgs e)
        {
            if(txtNev.Text == null  || txtNev.Text =="")
            {
                MessageBox.Show("Kérlek add meg a neved!");

            }
            else
            {
                MessageBox.Show($"Szia{txtNev.Text}!");
            }
        }
    }
}