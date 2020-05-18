using System;
using System.Collections.Generic;
using System.Text;

namespace iacobeduard
{
    class DoubleSimpleRoom : Room
    {
        public int BasicPrice = 120;

        public Tuple<int,int,int> Price(string days, int NumberRoom)
        {
            BasicPrice = BasicPrice * Convert.ToInt32(days);
            if(NumberRoom == 2) { FreeRooms -= 1; }
            return Tuple.Create(BasicPrice,NumberRoom,FreeRooms);
        }
    }
}
