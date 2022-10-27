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
    }
}
