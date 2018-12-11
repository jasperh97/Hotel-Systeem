using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Systeem
{
    class Reservation
    {
        public Reservation(int reservationNr, DateTime startDate, DateTime endDate, List<Room> rooms)
        {
            ReservationNr = reservationNr;
            StartDate = startDate;
            EndDate = endDate;
            Rooms = rooms;
        }

        public int ReservationNr { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public List<Room> Rooms { get; }

        public void CancelReservation(int reservationNr)
        {

        }

        //public Reservation AddReservation()
        //{
        //    return new Reservation();
        //}

        public string GetReservationInfo(int reservationNr)
        {
            return "";
        }
    }
}
