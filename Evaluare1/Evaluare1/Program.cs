using System;

namespace Evaluare1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bucovina Guest House!");
            Console.WriteLine("Select number of which type of room do you prefer to stay?");
            Console.WriteLine("1->Family Room");
            Console.WriteLine("2->Double Room");
            Console.WriteLine("3,4->Double Room Mountain View");
            Console.WriteLine("5,6->Attic Room");
            int numberRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("How many days will you stay in our Guest House?");
            int daysReserved = int.Parse(Console.ReadLine());
            if (numberRoom == 1) {
                FamilyRoom fm = new FamilyRoom(numberRoom,daysReserved);
                Console.WriteLine("You reserved room no. " + numberRoom + " Days Reserved: " + daysReserved + " Price: " + fm.calculateTotalPrice());
            }
            if (numberRoom == 2)
            {
                DoubleRoom dr = new DoubleRoom(numberRoom,daysReserved);
                Console.WriteLine("You reserved room no. " + numberRoom + " Days Reserved: " + daysReserved + " Price: " + dr.calculateTotalPrice());
            }
            if (numberRoom == 3||numberRoom==4)
            {
                DoubleRoomMountainView drmv = new DoubleRoomMountainView(numberRoom,daysReserved);
                Console.WriteLine("You reserved room no. " + numberRoom + " Days Reserved: " + daysReserved + " Price: " + drmv.calculateTotalPrice());
            }
            if (numberRoom == 5||numberRoom==6)
            {
                AtticRoom ar = new AtticRoom(numberRoom,daysReserved);
                Console.WriteLine("You reserved room no. " + numberRoom + " Days Reserved: " + daysReserved + " Price: " + ar.calculateTotalPrice());
            }
        }
    }
}
