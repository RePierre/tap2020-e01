using System;
using System.Collections.Generic;
using System.Text;

namespace anamariaginger
{
    class Family: Rooms
    {
        public Family(int roomnr, int nrnights) : base(roomnr, nrnights)
        {

        }
       
        public override decimal get_price_to_pay()
        {
            
            if (roomnr == 1)
                price = 200m*nrnights;
            else if (nrnights > 3)
                price = 200m *3 + 200m * (80 / 100) * (nrnights - 3);
            return price;
        }
    }
}
