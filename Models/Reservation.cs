using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public DateTime StartTime { get; }  // бронь с...

        public DateTime EndTime { get; }    // бронь до... 

        public Reservation(RoomID roomID, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
