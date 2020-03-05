using System;

namespace iacobeduard
{
    class Program
    {
        static void Main(string[] args)
        {
            int camera = 0;
            string raspuns = null, days = null;
            Room rm = new Room();
            FamilyRoom fm = new FamilyRoom();
            AtticRoom at = new AtticRoom();
            DoubleSimpleRoom dsr = new DoubleSimpleRoom();
            DoubleRoomMV drmv = new DoubleRoomMV();

            Console.WriteLine("Hi, do you want to make a bookin?(Y/N): ");
            raspuns = Console.ReadLine();

            if(raspuns == "Y" || raspuns == "y")
            {
                int freeRooms = rm.FreeRooms;
                if(freeRooms != 0)
                {
                    Console.WriteLine("Alright then, we have {0} free rooms, do you want to book?(Y/N): ", freeRooms);
                    raspuns = Console.ReadLine();
                    if(raspuns == "Y" || raspuns == "y")
                    {
                        Console.WriteLine("We have " +
                            "-(1) Family Room" +
                            "-(2) Double Simple Room" +
                            "-(3,4) Double Room with Mountain View" +
                            "-(5,6) Attic Room");
                        camera = Convert.ToInt32(Console.ReadLine());
                        if(camera == 1)
                        {
                            Console.WriteLine("You booked a Family Room, for how many days do you want to stay?");
                            days = Console.ReadLine();
                            Console.WriteLine("Okay then, the price for your book is {0}, you booked room number {1}. Have a nice holiday!", fm.Price(days,camera).Item1, fm.Price(days,camera).Item2);
                        }
                        else if(camera == 2)
                        {
                            Console.WriteLine("You booked a Double Simple Room, for how many days do you want to stay?");
                            days = Console.ReadLine();
                            Console.WriteLine("Okay then, the price for your book is {0}, you booked room number {1}. Have a nice holiday!", dsr.Price(days, camera).Item1, dsr.Price(days,camera).Item2);
                        }
                        else if(camera == 3 || camera == 4)
                        {
                            Console.WriteLine("You booked a Double Room with Mountain View, for how many days do you want to stay?");
                            days = Console.ReadLine();
                            Console.WriteLine("Okay then, the price for your book is {0}, you booked room number {1}. Have a nice holiday!", drmv.Price(days, camera).Item1, drmv.Price(days,camera).Item2);
                        }
                        else if(camera == 5 || camera == 6)
                        {
                            Console.WriteLine("You booked a Attic Room, for how many days do you want to stay?");
                            days = Console.ReadLine();
                            Console.WriteLine("Okay then, the price for your book is {0}, you booked room number {1}. Have a nice holiday!", at.Price(days, camera).Item1, at.Price(days,camera).Item2);
                        }
                    }
                }
            }
        }
    }
}
