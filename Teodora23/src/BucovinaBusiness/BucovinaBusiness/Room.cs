using System;
using System.Collections.Generic;
using System.Text;

namespace BucovinaBusiness
{
    public abstract class Room
    {
        public decimal PricePerNight { get; protected set; }
        public decimal CalculateReservationPrice(int numberOfNights)
        {
            decimal reservationPrice;
            if (numberOfNights > 3)
            {
                reservationPrice = 3 * this.PricePerNight;
                reservationPrice += (numberOfNights - 3) * (this.PricePerNight - (this.PricePerNight * 20 / 100));
            }
            else
            {
                reservationPrice = numberOfNights * this.PricePerNight;
            }
            return reservationPrice;
        }

    }
}
