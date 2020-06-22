using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Room : GuestHouse
    {
        public static int count = 0;
        public bool status { get; set; }
        public int id { get; set; }
        public Room()
        {
            count++;
        }
        ~Room()
        {
            count--;
        }

        public static  List<Room> RoomData()
        { List<Room> Rooms = new List<Room>();
            Rooms.Add(new Room { id = count, level = 1, roomType = "camera de familie", priceNight = 200, status=false });
            Rooms.Add(new Room { id = count, level = 3, roomType = "camera dubla simpla", priceNight = 120, status = false });
            Rooms.Add(new Room { id = count, level = 3, roomType = "camera dubla cu vedere la munte", priceNight = 150, status = false });
            Rooms.Add(new Room { id = count, level = 3, roomType = "camera dubla cu vedere la munte", priceNight = 150, status = false });
            Rooms.Add(new Room { id = count, level = 2, roomType = "camera de mansarda", priceNight = 100, status = false });
            Rooms.Add(new Room { id = count, level = 2, roomType = "camera de mansarda", priceNight = 100, status = false });
            return Rooms;
        }
        public static void displayRooms(List<Room> Rooms)
        {
            foreach(var Room in Rooms)
            {
                Console.WriteLine($"{Room.id} {Room.level} {Room.roomType} {Room.priceNight} ");
            }
        }
        public int getCount()
        {
            return count;
        }

    }
}
