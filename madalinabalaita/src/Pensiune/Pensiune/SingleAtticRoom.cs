﻿namespace Pensiune
{
    
   
        public class SingleAtticRoom:Rooms
        {
        public SingleAtticRoom(int room, int nrNights) : base(room,nrNights)
        {
        }
        public override double get_price()
        {
            if (nrNights > 3) return 100 * 3 + 100 * (nrNights - 3) * 0.8;
            return 100 * nrNights;
        }
    }
    
}
