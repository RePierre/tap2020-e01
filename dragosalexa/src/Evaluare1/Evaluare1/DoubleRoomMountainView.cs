﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    class DoubleRoomMountainView:Room
    {
        public int price = 150;
        public DoubleRoomMountainView(int numberRoom, int daysReserved) : base(numberRoom, daysReserved) { }
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

