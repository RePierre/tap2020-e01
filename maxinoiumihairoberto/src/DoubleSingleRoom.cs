using System;
using System.Collections.Generic;
using System.Text;

namespace Mansion
{
    class DoubleSingleRoom : Room
    {
        public double RoomPrice { get; set; }
        public int NumberOfNights { get; set; }
        DateTime Arrive;
        DateTime Gone;

        public double Discount { get; set; }
        public DoubleSingleRoom(double Price, DateTime Arrive, DateTime Gone)
        {
            this.Price = Price;
            this.Arrive = Arrive;
            this.Gone = Gone;


        }

        public override void CalculatePrice(double Price, int ChamberNumber, DateTime beginTime, DateTime endTime, int daysOver)
        {
            double TotalPrice = 0;
            if (ChamberNumber == 1)
            {
                var date = endTime.Subtract(beginTime).TotalDays;
                if (date > 0 && date < 3)
                {
                    TotalPrice = TotalPrice + Price * date;
                }
                else
                {
                    TotalPrice = TotalPrice + Price * date;
                    //Discount apears!! 
                    for (int i = 1; i <= daysOver; i++)
                    {
                        TotalPrice = TotalPrice + 0.2 * Price;
                    }
                }

                Console.WriteLine("The price for this room is :" + TotalPrice);
            }
            else
            {
                Console.WriteLine("This Room is not for rent");
            }
        }
    }
}
