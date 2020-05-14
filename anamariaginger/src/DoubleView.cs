using System;
using System.Collections.Generic;
using System.Text;

namespace anamariaginger
{
    class DoubleView:Rooms
    {
        public DoubleView(int roomnr, int nrnights) : base(roomnr, nrnights)
        {

        }
        public override decimal get_price_to_pay()
        {
            if (roomnr == 3 || roomnr == 4)
                price = 150m * nrnights;
            else if (nrnights > 3)
                price = 150m * 3 + 150m * (80 / 100) * (nrnights - 3);
            return price;
        }
    }
}
