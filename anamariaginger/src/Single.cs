using System;
using System.Collections.Generic;
using System.Text;

namespace anamariaginger
{
    class Single: Rooms
    {
        public Single(int roomnr, int nrnights) : base(roomnr, nrnights)
        {

        }
        public override decimal get_price_to_pay()
        {
            if (roomnr == 5||roomnr==6)
                price = 100m*nrnights;
           else if (nrnights > 3)
                price = 100m * 3 + 100m*(80/100)* (nrnights - 3);
            return price;
        }
    }
}
