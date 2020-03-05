using System;

namespace Guest_house
{
    class Program
    {
        static string getRoomType(Room room)
        {
            if (room is AtticRoom)
                return "AtticRoom";
            else if (room is DoubleRoomView)
                return "Double Room with View";
            else if (room is DoubleSimpleRoom)
                return "Double Room";
            else if (room is FamilyRoom)
                return "Family room";
            else return "Maybe it's not a room?";
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                if (i <= 1)
                    Reception.GetReception().AddRoom(new FamilyRoom(i));
                else if (i <= 2)
                    Reception.GetReception().AddRoom(new DoubleSimpleRoom(i));
                else if (i <= 4)
                    Reception.GetReception().AddRoom(new DoubleRoomView(i));
                else Reception.GetReception().AddRoom(new AtticRoom(i));
            }

            DateTime start = new DateTime(2020, 12, 10), end = new DateTime(2020, 12, 20);
            int id = 2;
            Console.WriteLine(getRoomType(Reception.GetReception().GetRoom(id)) + " " + Reception.GetReception().GetRoomPrice(id, start, end));
            id = 5;
            Console.WriteLine(getRoomType(Reception.GetReception().GetRoom(id)) + " " + Reception.GetReception().GetRoomPrice(id, start, end));
        }
    }
}