using System;
using System.Collections.Generic;
using System.Text;

namespace BucovinaBusiness
{
    class Reception
    {
        public decimal CalculateReservationPrice(string roomType, DateTime startDate, DateTime endDate)
        {
            double numberOfNights = (endDate - startDate).TotalDays;
            decimal reservationPrice = 0m;
            Room room;
            switch (roomType)
            {
                case "1":
                    room = new FamilyRoom();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfNights);
                    break;
                case "2":
                    room = new DoubleRoomSimple();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfNights);
                    break;
                case "3":
                    room = new DoubleRoomMountainView();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfNights);
                    break;
                case "4":
                    room = new AtticRoom();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfNights);
                    break;
                default:
                    throw new InvalidOperationException("Please choose an existing room"); 
            }
            return reservationPrice;
        }
    }
}
