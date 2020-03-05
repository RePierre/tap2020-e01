using System;
using System.Collections.Generic;
using System.Text;

namespace iacobeduard
{
    class FamilyRoom : Room
    {
        public int BasicPrice = 200;
        
        
        public Tuple<int,int,int> Price(string days, int NumberRoom)
        {
            BasicPrice = BasicPrice * Convert.ToInt32(days);
            FreeRooms -= 1;
            if(NumberRoom == 1) {
                NumberRoom = 1;
                FreeRooms -= 1;
            }
            return Tuple.Create(BasicPrice,NumberRoom,FreeRooms);
        }
    }
}
