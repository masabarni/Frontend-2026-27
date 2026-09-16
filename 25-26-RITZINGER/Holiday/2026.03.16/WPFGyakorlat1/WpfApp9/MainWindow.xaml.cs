using System.Collections.ObjectModel;
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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Reservation
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public int Count { get; set; }

    }

    public partial class MainWindow : Window
    {
        public ObservableCollection<Reservation> Reservations { get; set; }
        public Reservation SelectedReservation { get; set; }
        public int SelectedReservationIndex { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Reservations = new ObservableCollection<Reservation>
            {
            new Reservation { Name = "Kovács János", Amount = 21300, Count = 2 },
            new Reservation { Name = "Nagy Mária", Amount = 45600, Count = 3}
            };

            DataContext = this;
        }

        private void EditCommand(object sender, RoutedEventArgs e)
        {
            EditReservationWindow editWindow = new EditReservationWindow(SelectedReservation);
            //editWindow.ShowDialog();
            Reservation updated;

            // DialogResult = true; -> ezzel kell zárni a EditReservationWindow dialog ablakot !!!
            if (editWindow.ShowDialog() == true)
            {
                // szerkesztett adat visszakapása
                updated = editWindow.EditedReservation;
                //MessageBox.Show(object.ReferenceEquals(updated, SelectedReservation).ToString());

                int index = Reservations.IndexOf(SelectedReservation);

                // itt módosul a főaldali datagrid
                // 1. Módszer (Ha másolat készül a SelectedReservation objektumból az EditReservationWindow osztályban)
                if (index != -1)
                {
                    Reservations[index] = updated; // 🔥 EZ FRISSÍT
                }

                // 2. Módszer (Ha másolat NEM készül a SelectedReservation objektumból az EditReservationWindow osztályban)
                // DataGrid frissítése -> ezután frissül be a szerkesztett adattal a főoldal datagrid-je!!!!
                //dataGrid.Items.Refresh();

            }
            else // Close(); hívással az else ágban kell megcsinálni a frissítést
            {
                // szerkesztett adat visszakapása
                updated = editWindow.EditedReservation;
                //MessageBox.Show(object.ReferenceEquals(updated, SelectedReservation).ToString());

                int index = Reservations.IndexOf(SelectedReservation);

                // itt módosul a főaldali datagrid
                // 1. Módszer (Ha másolat készül a SelectedReservation objektumból az EditReservationWindow osztályban)
                if (index != -1)
                {
                    Reservations[index] = updated; // 🔥 EZ FRISSÍT
                }

                // 2. Módszer (Ha másolat NEM készül a SelectedReservation objektumból az EditReservationWindow osztályban)
                // DataGrid frissítése -> ezután frissül be a szerkesztett adattal a főoldal datagrid-je!!!!
                //dataGrid.Items.Refresh();
            }
        }

        private void DeleteCommand(object sender, RoutedEventArgs e)
        {
            Reservations.RemoveAt(SelectedReservationIndex);
        }

        private void AddReservationCommand(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow(Reservations);
            editWindow.Show();
        }
    }
}