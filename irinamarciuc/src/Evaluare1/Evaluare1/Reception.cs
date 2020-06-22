using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare1
{
    public abstract class Reception
    {
        
        protected DateTime firstday;
        protected DateTime lastday;

        protected Reception(DateTime firstday,DateTime lastday)
        {
            this.firstday = firstday;
            this.lastday = lastday;
        }
        public int CalculateNumberofdays(DateTime start,DateTime stop)
        {
            return stop.Day - start.Day;

        }
        public decimal CalculatePriceAfterDiscount(decimal price)
        {
            price = 3 * price + (price - 2 * price / 10) *(CalculateNumberofdays(firstday,lastday)-3);
            return price;
        }
       
        public abstract decimal FinalPrice(int number,DateTime start,DateTime stop);
    }
}
