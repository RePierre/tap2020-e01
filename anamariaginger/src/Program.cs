using System;

namespace anamariaginger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of room you want:" +
                " 1)Family " +
                " 2)Double " +
                " 3)&4)Double with a view " +
                " 5)&6)Single ");
            int roomnr = int.Parse(Console.ReadLine());
            Console.WriteLine("Please tell us how many nights you will stay");
            int nights= int.Parse(Console.ReadLine());
            if (roomnr == 1)
            {
                Family family = new Family(roomnr, nights);
                Console.WriteLine("The price will be :"+family.get_price_to_pay());

            }
            if (roomnr == 2)
            {
                DoubleR doubleR = new DoubleR(roomnr, nights);
                Console.WriteLine("The price will be :" + doubleR.get_price_to_pay());

            }
            if (roomnr == 3||roomnr==4)
            {
                DoubleView doubleView = new DoubleView(roomnr, nights);
                Console.WriteLine("The price will be :" + doubleView.get_price_to_pay());

            }
            if (roomnr == 5||roomnr==6)
            {
                Single single = new Single(roomnr, nights);
                Console.WriteLine("The price will be :" + single.get_price_to_pay());

            }
        }
    }
}
