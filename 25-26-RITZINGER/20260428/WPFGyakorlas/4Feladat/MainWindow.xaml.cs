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

namespace _4Feladat
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

        private void Jelszo_TextChanged(object sender, TextChangedEventArgs e)
        {
            int pontszam = 0;
            string jelszo = txtJelszo.Text;

            bool vanSzam = false;
            bool vanNagyBetu = false;
            bool vanSpecialis = false;
            string specialisKarekterek = "!@#$%";

            if (jelszo.Length > 6) pontszam += 25;
            {
                foreach (char c in jelszo)
                {
                    if (char.IsDigit(c)) vanSzam = true;
                    if (char.IsUpper(c)) vanNagyBetu = true;
                    if (specialisKarekterek.Contains(c)) vanSpecialis = true;
                }

                if (vanSzam) pontszam += 25;
                if(vanNagyBetu) pontszam += 25;
                if (vanSpecialis) pontszam += 25;

                pbErosseg.Value = pontszam;
                switch(pontszam)
                {
                    case 0:
                        txtErosseg.Text = "Gyenge";
                        break;
                    case 25:
                        txtErosseg.Text = "Közepes";
                        break;
                    case 50:
                        txtErosseg.Text = "Megfelelő";
                        break;
                    case 75:
                    case 100:
                        txtErosseg.Text = "Erős";
                        break;
                    default:
                        txtErosseg.Text = "Gyenge";
                        break;
                }
            }
        }
    }
}