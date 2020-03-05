using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    class SimpleDouble : Reception
    {
        public SimpleDouble(DateTime firstday, DateTime lastday) : base(firstday, lastday) { }
        public override decimal FinalPrice(int number, DateTime firstday, DateTime lastday)
        {
            decimal price = 120m;
            int n = CalculateNumberofdays(firstday,lastday);
            if (number == 2 || number==3 || number==4)
            {
                if (n <= 3) price *= n;
                else price = price = CalculatePriceAfterDiscount(price);
            }
            return price;

        }
    }
}
