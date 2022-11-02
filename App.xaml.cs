using Reservoom.Exceptions;
using Reservoom.Models;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    Hotel hotel = new Hotel("SingletonSean Suites");
        //    try
        //    {


        //    hotel.MakeReservation(new Reservation(
        //        new RoomID(1, 2), "SingletonSean", 
        //        /* дата начала бронирования */
        //        new DateTime(/* year moth day */ 2022, 10, 30 ), 
        //        /* конечная дата бронирования */
        //        new DateTime(2022, 11, 5)));

        //    hotel.MakeReservation(new Reservation(
        //        new RoomID(1, 3), "SingletonSean",
        //        /* дата начала бронирования */
        //        new DateTime(/* year moth day */ 2022, 10, 30),
        //        /* конечная дата бронирования */
        //        new DateTime(2022, 11, 5)));
        //    }
        //    catch (ReservationConflictException ex)
        //    {


        //    }

        //    IEnumerable<Reservation> reservations = hotel.GetAllReservations();

        //    base.OnStartup(e);
        //}

        private readonly Hotel _hotel;

        public App()
        {
            _hotel = new Hotel("SingletonSean Suite");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_hotel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
