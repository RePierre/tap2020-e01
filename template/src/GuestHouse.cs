using System;

namespace Andreea523
{
    abstract class GuestHouse
    {
        static private double familyRoom = 200 ;
        static private double doubleRoom = 120;
        static private double doubleRoomView = 150;
        static private double singlePersonRoom = 100;
        static private double reduction, sum;
        static private string rooms, days;
        static private int daysParse;

        protected abstract double Reduction(double price);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What type of room do you want?(family room, double room, double room with mountains view, room for a single person)?");
            rooms = Console.ReadLine();
            switch (rooms)
            {
                case "family room":
                    
                    Console.WriteLine("The price for family room is "+familyRoom+"RON/night, it is the room number 1 and it's located on ground floor");
                    Console.WriteLine("How many nights do you want to stay?");
                    days = Console.ReadLine();
                    daysParse = Convert.ToInt32(days);
                    Console.WriteLine("The total price for " + days + "day/days is: " + familyRoom * daysParse + "RON");
                    break;
                case "double room":
                    Console.WriteLine("The price for the double room is "+doubleRoom+"RON/night, it is the room number 2 and it's located on 1st floor");
                    Console.WriteLine("How many nights do you want to stay?");
                    days = Console.ReadLine();
                    daysParse = Convert.ToInt32(days);
                    Console.WriteLine("The total price for " + days + "day/days is: " + doubleRoom * daysParse + "RON");
                    break;
                case "double room with mountains view":
                    Console.WriteLine("The price for the double room with mountains view is " + doubleRoomView + "RON, it is the room number 3 and 4 and it's located on 1st floor");
                    Console.WriteLine("How many nights do you want to stay?");
                    days = Console.ReadLine();
                    daysParse = Convert.ToInt32(days);
                    Console.WriteLine("The total price for " + days + "day/days is: " + doubleRoomView * daysParse + "RON");
                    break;
                case "room for a single person":
                    SingleRoom room = new SingleRoom();
                    Console.WriteLine("The price for the room for a single person is " + singlePersonRoom + "RON, it is the room number 5 and 6 and it's located on 1st floor");
                    Console.WriteLine("If you book more than 3 nights, you have a 20% discount for each additional night!");
                    Console.WriteLine("How many nights do you want to stay?");
                    days = Console.ReadLine();
                    daysParse = Convert.ToInt32(days);
                    if(daysParse<=3 && daysParse != 0)
                    {
                        Console.WriteLine("The total price for " + days + "day/days is: " + singlePersonRoom * daysParse + "RON");
                    }
                    else
                    {
                        reduction = room.Reduction(singlePersonRoom);
                        Console.WriteLine("Price after reduction:"+ reduction +"RON for the nights over 3.");
                        sum = singlePersonRoom * 3 + reduction * (daysParse - 3);
                        Console.WriteLine("The total price for " + days + "day/days is: " + sum + "RON");
                    }
                   
                    break;
            }
        }
    }
}
