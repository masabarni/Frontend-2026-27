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

namespace WPF_Login
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const string message = "A jelszó és a felhasználónév nem lehet üres!!";
            if(txtFelhasznalo.Text != "" ||  txtJelszo.Password != "" )
            {
                var result = MessageBox.Show(message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fejlecText.Foreground = new SolidColorBrush(Colors.Brown);
        }
    }
}