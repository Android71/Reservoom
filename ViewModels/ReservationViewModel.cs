using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID.ToString();
        public string Username => _reservation.Username;
        public string StartDate => _reservation.StartTime.ToString("d");  // бронь с...
        public string EndDate => _reservation.EndTime.ToString("d");      // бронь до...



        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
