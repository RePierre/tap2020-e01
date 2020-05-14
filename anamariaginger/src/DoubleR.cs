using System;
using System.Collections.Generic;
using System.Text;

namespace anamariaginger
{
   class DoubleR: Rooms
    {
        public DoubleR(int roomnr, int nrnights) : base(roomnr, nrnights)
        {

        }
        public override decimal get_price_to_pay()
        {
            if (roomnr == 2)
                price = 120m*nrnights;
            else if (nrnights > 3)
                price = 120m * 3 + 120m * (80 / 100) * (nrnights - 3);
            return price;
        }



    }
}
