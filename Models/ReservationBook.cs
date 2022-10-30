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

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(r => r.Username == username);
        }
    }
}
