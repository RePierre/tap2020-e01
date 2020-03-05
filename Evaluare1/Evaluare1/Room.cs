using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    public abstract class Room
    {
        public int numberRoom;
        public int daysReserved;

        public Room(int daysReserved) {
            this.daysReserved = daysReserved;
        }
        public abstract double calculateTotalPrice();
    }
}
