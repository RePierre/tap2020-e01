using System;
using System.Collections.Generic;
using System.Text;

namespace Guest_house
{
    public abstract class Room
    {
        public decimal nightCost;
        public int id;
        public Room(decimal nightCost, int id)
        {
            this.id = id;
            this.nightCost = nightCost;
        }
        public virtual decimal GetTotalCost(int totalNights)
        {
            return totalNights * nightCost;
        }

    }
}
