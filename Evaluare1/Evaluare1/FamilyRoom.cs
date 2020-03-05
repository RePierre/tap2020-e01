using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    class FamilyRoom:Room
    {
        public int price = 200;
        public FamilyRoom(int daysReserved) : base(daysReserved) { }
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

