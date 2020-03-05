using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Reception:Room
    {
        List<Room> Rooms = Room.RoomData();
        private double discount = 0.2;
        public double getDiscount(int id)
        {
            if (id == 2) return discount;
            else return 0;
        }
        public int getPrice(int nights, int id)
        {
            return Rooms.ElementAt(id - 1).priceNight * nights;
        }
        public bool makeReservation(int id)
        {
            if (Rooms.ElementAt(id - 1).status == false) return true;
            else return false;
        }

        public void  handRoom(int id)
        {
            Rooms.ElementAt(id - 1).status = true;
        }
    }
}
