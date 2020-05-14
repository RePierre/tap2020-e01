using System;
using System.Collections.Generic;
using System.Text;

namespace Guest_house
{
    public class AtticRoom : Room
    {
        public AtticRoom(int id) : base(100m, id) { }
        public override decimal GetTotalCost(int totalNights)
        {
            if (totalNights > 3)
                return nightCost * 3 + (totalNights - 3) * nightCost * 0.8m;
            else
                return totalNights * nightCost;
        }
    }
}
