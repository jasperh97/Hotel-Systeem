using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Systeem
{
    class RestaurantReservation
    {
        public RestaurantReservation(int restaurantReservationNr, string foodType, DateTime date)
        {
            RestaurantReservationNr = restaurantReservationNr;
            FoodType = foodType;
            Date = date;
        }

        public int RestaurantReservationNr { get; }
        public string FoodType { get; }
        public DateTime Date { get; }

        //public List<RestaurantReservation> GetRestaurantReservations(string foodType)
        //{
        //    return;
        //}
    }
}
