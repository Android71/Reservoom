using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class ReservationBook
    {
        //private readonly List<Reservation> _roomsToReservations;
        private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservations; // В будущем изменим на List<Reservation>
        
        public ReservationBook()
        {
            //_roomsToReservations = new List<Reservation>();
            _roomsToReservations = new Dictionary<RoomID, List<Reservation>>();
        }
    }
}
