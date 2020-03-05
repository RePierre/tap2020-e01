using System;
using System.Collections.Generic;
using System.Text;

namespace BucovinaBusiness
{
    class Reception
    {
        public decimal CalculateReservationPrice(int roomType, DateTime startDate, DateTime endDate)
        {
            int numberOfDays = (endDate - startDate).Days;
            decimal reservationPrice = 0m;
            Room room;
            switch (roomType)
            {
                case 1:
                    room = new FamilyRoom();
                    reservationPrice = room.CalculateReservationPrice(numberOfDays);
                    break;
                case 2:
                    room = new DoubleRoomSimple();
                    reservationPrice = room.CalculateReservationPrice(numberOfDays);
                    break;
                case 3:
                    room = new DoubleRoomMountainView();
                    reservationPrice = room.CalculateReservationPrice(numberOfDays);
                    break;
                case 4:
                    room = new AtticRoom();
                    reservationPrice = room.CalculateReservationPrice(numberOfDays);
                    break;
                default:
                    break;
            }
            return reservationPrice;
        }
    }
}
