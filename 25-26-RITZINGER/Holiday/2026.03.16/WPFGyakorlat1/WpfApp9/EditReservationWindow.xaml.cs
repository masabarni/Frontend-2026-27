using System;
using System.Collections.Generic;
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
    /// Interaction logic for EditReservationWindow.xaml
    /// </summary>
    public partial class EditReservationWindow : Window
    {
        public string ResevationName { get; set; }

        public int ReservationAmount { get; set; }

        public int ReservationCount { get; set; }

        // 1. módszer
        public Reservation EditedReservation { get; private set; }

        // 2. módszer
        //public Reservation reservation;
        public EditReservationWindow(Reservation input)
        {
            InitializeComponent();
            
            // 1. módszer, amikor másolat készül a kiválasztott sor eleméről
            // 🔥 MÁSOLAT
            EditedReservation = new Reservation
            {
                Name = input.Name,
                Amount = input.Amount,
                Count = input.Count
            };
            // UI property-k frissítése a konstruktoban paraméterként megkapott kiválasztott datagrid elemmel
            // Ha ez nincs a UI nem kapja meg a főoldalról érkező adatokat és minden marad üres/0
            ResevationName = EditedReservation.Name;
            ReservationAmount = EditedReservation.Amount;
            ReservationCount = EditedReservation.Count;

            // 2. módszer, amikor másolat NEM készül a kiválasztott sor eleméről, csak a refernciáját vesszük át vagyis ugyanazt az objektumot érjük el
            // egy másik változóval ebben az esetben a reservation field-en keresztül
            //reservation = inputData;
            DataContext = this;
        }

        private void ModifyReservation(object sender, RoutedEventArgs e)
        {            
            EditedReservation.Name = ResevationName;
            EditedReservation.Amount = ReservationAmount;
            EditedReservation.Count = ReservationCount;

            // Mindkét ablak bezárási módszer használható csak ez egyiknél az if a másiknál az else ág hajtódik végre
            // 1. módszer
            // if (editWindow.ShowDialog() == true) feltétel teljesül, így az if ágban fut le a frissítési logika
            //DialogResult = true;

            // 2. módszer
            // a sima Close hívás estén főoldalon a 
            // if (editWindow.ShowDialog() == true) feltétel nem teljesül !!! -> így a frissítés logika itt nem fut le, hanem az else ágban
            this.Close();
        }
    }
}
