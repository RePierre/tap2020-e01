using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    class DoubleRoom:Room
    {
        public int price=120;
        public DoubleRoom(int daysReserved) : base(daysReserved) {
        }
        public override double calculateTotalPrice()
        {

            if (daysReserved > 3)
            {
                return 3 * price + (daysReserved - 3) * 0.8 * price;
            }
            else
                return daysReserved * price;
        }
    }
}
