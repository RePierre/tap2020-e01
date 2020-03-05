using System;
using System.Collections.Generic;
using System.Text;

namespace BucovinaBusiness
{
    class Reception
    {
        public decimal CalculateReservationPrice(int roomType, DateTime startDate, DateTime endDate)
        {
            double numberOfDays = (endDate - startDate).TotalDays;
            decimal reservationPrice = 0m;
            Room room;
            switch (roomType)
            {
                case 1:
                    room = new FamilyRoom();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfDays);
                    break;
                case 2:
                    room = new DoubleRoomSimple();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfDays);
                    break;
                case 3:
                    room = new DoubleRoomMountainView();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfDays);
                    break;
                case 4:
                    room = new AtticRoom();
                    reservationPrice = room.CalculateReservationPrice((int)numberOfDays);
                    break;
                default:
                    break;
            }
            return reservationPrice;
        }
    }
}
