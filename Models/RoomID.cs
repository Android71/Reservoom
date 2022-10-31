using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Перегрузка операторов в C#
//https://www.youtube.com/watch?v=GxpeqHHO-PA&list=PLIIXgDT0bKw4OmiZ9yGmShKsY0XncViZ8&index=11  

namespace Reservoom.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        public override bool Equals(object obj)
        {
            return obj is RoomID roomID &&
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        // ********************************************************************************
        /// <summary>
        /// Перегрузка GetHashCode для успешного выполнения Equals
        /// </summary>
        /// <returns></returns>
        // <created>,30.10.2022</created>
        // <changed>,30.10.2022</changed>
        // ********************************************************************************
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        // ********************************************************************************
        /// <summary>
        /// Перегрузка оператора ==
        /// </summary>
        // <created>,30.10.2022</created>
        // <changed>,30.10.2022</changed>
        // ********************************************************************************
        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        // ********************************************************************************
        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomID1"></param>
        /// <param name="roomID2"></param>
        /// <returns></returns>
        // <created>,31.10.2022</created>
        // <changed>,31.10.2022</changed>
        // ********************************************************************************
        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }

    }

    
}
