using System;
using System.Collections.Generic;
using System.Text;

namespace Guest_house
{
    public class Reception
    {
        private List<Room> rooms;
        private static Reception reception;
        public static Reception GetReception()
        {
            if (reception == null)
            {
                reception = new Reception();
                return reception;
            }
            else
                return reception;
        }
        private Reception() { rooms = new List<Room>(); }
        public void AddRoom(Room room)
        {
            foreach (Room r in rooms)
                if (r.id == room.id)
                    throw new SystemException("Room already in.");

            rooms.Add(room);
        }
        public Room GetRoom(int id)
        {
            foreach (Room r in rooms)
                if (r.id == id)
                    return r;
            throw new SystemException("No such room");
        }
        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }
        public decimal GetRoomPrice(int id, DateTime start, DateTime end)
        {
            if (id <= 0)
                throw new SystemException("Invalid ID");
            int nights = (int)(end - start).TotalDays;
            Console.WriteLine(nights);
            if (nights <= 0)
                throw new SystemException("Maybe the dates are wrong?");
            foreach (Room r in rooms)
                if (r.id == id)
                    return r.GetTotalCost(nights);
            throw new SystemException("No such room");
        }

    }
}
