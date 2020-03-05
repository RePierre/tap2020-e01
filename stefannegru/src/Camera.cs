//using System;
namespace camera
{

    public abstract class camere
    {
        protected double price;
        int NrNopti;

        public camere(double price)
        {
            this.price = price;
        }

        public abstract double reducere()
        {
            if (NrNopti > 3)
            {
                return 20 * price / 100;
            }
            return 0;
        }

        public decimal get_price()
        {
            return price - reducere();
        }

       
    }


}