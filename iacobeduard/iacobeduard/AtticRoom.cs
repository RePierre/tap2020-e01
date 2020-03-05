using System;
using System.Collections.Generic;
using System.Text;

namespace iacobeduard
{
    class AtticRoom : Room
    {
        public int BasicPrice = 100;
        
        public Tuple<int,int,int> Price(string days, int NumberRoom)
        {
            if(Convert.ToInt32(days) > 3)
            {
                BasicPrice -= Convert.ToInt32(BasicPrice * 0.20);
                BasicPrice *= Convert.ToInt32(days);
                if (NumberRoom == 5 || NumberRoom == 6) { FreeRooms -= 1; }
                return Tuple.Create(BasicPrice,NumberRoom, FreeRooms);
            }
            else
            {
                BasicPrice = BasicPrice * Convert.ToInt32(days);
                if (NumberRoom == 5 || NumberRoom == 6) { FreeRooms -= 1; }
                return Tuple.Create(BasicPrice, NumberRoom, FreeRooms);
            }
          
        }
        
    }
}
