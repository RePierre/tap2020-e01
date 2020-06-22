using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    class SpecialDouble : Reception
    {
        public SpecialDouble(DateTime firstday, DateTime lastday) : base(firstday, lastday) { }
        public override decimal FinalPrice(int number,DateTime firstday,DateTime lastday)
        {
            decimal price=150m;
            int n = CalculateNumberofdays(firstday, lastday);
            if (number == 5)
            {
                if (n <= 3) price *= n;
                else price = CalculatePriceAfterDiscount(price);
            }
            return price;

        }
    }
}
