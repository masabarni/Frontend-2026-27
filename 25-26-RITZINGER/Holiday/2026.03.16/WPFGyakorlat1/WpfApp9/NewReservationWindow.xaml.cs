using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public string ResevationName { get; set; }

        public int ReservationAmount { get; set; }

        public int ReservationCount { get; set; }

        public ObservableCollection<Reservation> Reservations { get; set; }
        public EditWindow(ObservableCollection<Reservation> datalist)
        {
            InitializeComponent();
            Reservations = datalist;
            DataContext = this;
        }

        private void NewReservation(object sender, RoutedEventArgs e)
        {
            Reservation newReservation = new Reservation();
            newReservation.Name = ResevationName;
            newReservation.Amount = ReservationAmount;
            newReservation.Count = ReservationCount;
            Reservations.Add(newReservation);
            this.Close();
        }
    }
}
