using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    class FamilyRoom : Reception
    {
        public FamilyRoom(DateTime firstday, DateTime lastday) : base(firstday, lastday) { }
        public override decimal FinalPrice(int number,DateTime firstday,DateTime lastday)
        {
            decimal price=200m;
            int n = CalculateNumberofdays(firstday, lastday);
            if (number == 1)
            {
                if (n <= 3) price *= n;
                else
                    price = CalculatePriceAfterDiscount(price);
            }
            return price;
            
        }
    }
}
