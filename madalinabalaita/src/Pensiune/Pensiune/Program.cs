using System;

namespace Pensiune
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int nrNights;

            Console.WriteLine("Welcome to our Bucovinian guest house! ");
            Console.WriteLine("What room wold you prefer(select a number)? We have a variety,please choose from below!");
            Console.WriteLine("Keep in mind that if the reservation is for more than 3 nights we have a special deal for you!");
            Console.WriteLine("1. Family room-fist floor-200/night");
            Console.WriteLine("2.(&3) Simple double room-second floor-120/night");
            Console.WriteLine("4.(&5) Double room with mountain view-second floor-150/night");
            Console.WriteLine("6. Attic room-attic-100/night");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please introduce how many days you will join us");
            nrNights = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                FamilyRoom fm1 = new FamilyRoom(choice, nrNights);
                Console.WriteLine("the price of your stay will sum up to:" + fm1.get_price());
            }
            if (choice == 2|| choice==3)
            {
                DoubleSimpleRoom dsr = new DoubleSimpleRoom(choice,nrNights);
                Console.WriteLine("the price of your stay will sum up to:" + dsr.get_price());
            }
           
            if (choice == 4 || choice == 5)
            {
                DoubleRoomWithView dwv = new DoubleRoomWithView(choice,nrNights);
                Console.WriteLine("the price of your stay will sum up to:" + dwv.get_price());
            }

            if (choice ==6)
            {
                SingleAtticRoom sar = new SingleAtticRoom(choice,nrNights);
                Console.WriteLine("the price of your stay will sum up to:" + sar.get_price());
            }

            


            Console.WriteLine("Thank you for choosing us and if you want to find out more about Bucovina you will find at the reception some flyers!");


        }
    }
}
