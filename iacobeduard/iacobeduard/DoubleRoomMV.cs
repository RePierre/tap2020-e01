using System;
using System.Collections.Generic;
using System.Text;

namespace iacobeduard
{
    class DoubleRoomMV : Room
    {
        public int BasicPrice = 150;

        public Tuple<int,int,int> Price(string days, int NumberRoom)
        {
            BasicPrice = BasicPrice * Convert.ToInt32(days);
            if(NumberRoom == 3 || NumberRoom == 4) { FreeRooms -= 1; }
            return Tuple.Create(BasicPrice, NumberRoom, FreeRooms);
        }
    }
}
