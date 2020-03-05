using System;
using System.Collections.Generic;
using System.Text;

namespace BucovinaBusiness
{
    public abstract class Room
    {
        public decimal PricePerNight { get; protected set; }
        public decimal CalculateReservationPrice(int numberOfDays)
        {
            decimal reservationPrice;
            if (numberOfDays > 3)
            {
                reservationPrice = 3 * this.PricePerNight;
                reservationPrice += (numberOfDays - 3) * (this.PricePerNight - (this.PricePerNight * 20 / 100));
            }
            else
            {
                reservationPrice = numberOfDays * this.PricePerNight;
            }
            return reservationPrice;
        }

    }
}
