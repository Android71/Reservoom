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
        public string Username { get; }
        public DateTime StartTime { get; }  // бронь с...
        public DateTime EndTime { get; }    // бронь до... 

        public TimeSpan Length => EndTime.Subtract(StartTime);  // продолжительность бронирования

        public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
