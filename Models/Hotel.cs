using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Hotel
    {
        private ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(String name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        
        // ********************************************************************************
        /// <summary>
        /// Get the reservations for a user
        /// </summary>
        /// <param name="username">The username of the user</param>
        /// <returns></returns>
        // ********************************************************************************
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
        }

        // ********************************************************************************
        /// <summary>
        /// Make a reservation
        /// </summary>
        /// <param name="reservation">The incoming reservation</param>
        /// <exception cref="ReservationConflictException">Thrown if incoming reservation conflicts with existing reservation.</exception>
        // ********************************************************************************
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
