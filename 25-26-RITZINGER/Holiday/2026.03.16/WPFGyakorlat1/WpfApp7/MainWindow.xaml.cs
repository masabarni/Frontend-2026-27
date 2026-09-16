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
using Microsoft.Win32;
using System.IO;

namespace WpfApp7
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt) | *.txt";

            if(dialog.ShowDialog() == true)
            {
                //txtFile.Text = dialog.FileName;
                txtFile.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt) | *.txt";

            if(dialog.ShowDialog() == true)
            {
                //txtFile.Text = dialog.FileName;
                File.WriteAllText(dialog.FileName, txtFile.Text);
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            //dialog.Filter = "Text files (*.txt) | *.txt";

            if (dialog.ShowDialog() == true)
            {
                //txtFile.Text = dialog.FileName;
                MessageBox.Show(dialog.PrintQueue.Name);
                //File.WriteAllText(dialog.FileName, txtFile.Text);
            }
        }
    }
}