using Reservoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;
        //private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservations; // В будущем изменим на List<Reservation>
        
        public ReservationBook()
        {
            //_roomsToReservations = new Dictionary<RoomID, List<Reservation>>();
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation /*incomingReservation*/)
        {
            foreach (Reservation exictingReservation in _reservations)
            {
                // Make Reservation extention in UseCase diagram
                if (exictingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(exictingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }
    }
}
