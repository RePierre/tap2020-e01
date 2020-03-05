using System;
using System.Collections.Generic;
using System.Text;

namespace Mansion
{
    class DoubleRoomViewMountain : Room
    {// We have 2 rooms of this type

        public double RoomPrice { get; set; }
        public int NumberOfNights { get; set; }
        DateTime Arrive;
        DateTime Gone;

        public double Discount { get; set; }
        public DoubleRoomViewMountain(double Price, DateTime Arrive, DateTime Gone)
        {
            this.Price = Price;
            this.Arrive = Arrive;
            this.Gone = Gone;


        }
        public override void CalculatePrice(double Price, int ChamberNumber, DateTime beginTime, DateTime endTime, int daysOver)
        {
            double TotalPrice = 0;
            
            
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
            
        }
    }

