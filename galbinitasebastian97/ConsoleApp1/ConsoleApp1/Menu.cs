using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleApp1
{
    class Menu
    {
        public static void consoleMenu()
        {
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("1.Afisare camere disponibile");

            Console.SetCursorPosition(15, 12);
            Console.WriteLine("2.Ocupa o camera");

            Console.SetCursorPosition(15, 13);
            Console.WriteLine("3.Plaseaza o rezervare");

            Console.SetCursorPosition(15, 14);
            Console.WriteLine("4.Previous");

            Console.SetCursorPosition(15, 15);
            Console.WriteLine("5.Iesire");
        }
        public static void againMenu()
        {
            string number = Console.ReadLine();
            int newch;
            int.TryParse(number, out newch);
            if (newch == 4)
            {
                Console.WriteLine("adsad");
                Console.Clear();
                consoleMenu();

            }
        }
        public static void addMenu()
        {
            char ch;
            List<Room> Rooms = Room.RoomData();
            consoleMenu();
            ch = Char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    Room.displayRooms(Rooms);
                    Console.WriteLine("4.Previous");
                    againMenu();
                    break;

                case '2':
                    Console.WriteLine("Introduce-ti id-ul camerei ");
                    string id_room = Console.ReadLine();
                    int idd;
                    int.TryParse( id_room, out idd);
                    Console.WriteLine("Cate nopti doriti sa sedeti?");
                    string nights = Console.ReadLine();
                    int nightss;
                    int.TryParse(nights, out nightss);
                   // Console.WriteLine(Reception.getPrice(nightss, idd));

                    againMenu();
                    break;

                case '3':
                    Console.WriteLine("Introduce-ti id-ul camerei ");
                    //Console.WriteLine(Rooms.ElementAt(0).priceNight);
                    againMenu();
                        break;

                case '4':
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
