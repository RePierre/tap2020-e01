using System;
using System.Collections.Generic;
using System.Text;

namespace Andreea523
{
    class SingleRoom:GuestHouse
    {
        protected override double Reduction(double price)
        {
            return price - 0.2 * price;
        }
    }
}
