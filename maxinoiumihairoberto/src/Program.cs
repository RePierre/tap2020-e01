using System;

/*
 FamillyRoom price 200 RON/night,
Double Single Room price 120 RON/night,
Double Room with Mountain View price 150 RON/nonightapte,
Garret Room price 100 RON/night
     */
namespace Mansion
{
    public abstract class Room
    {


        public double Price { get; set; }
        public string View { get; set; }
        public abstract void CalculatePrice(double Price,int ChamberNumber, DateTime BeginTime, DateTime EndTime, int daysOver);
        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int NumberOfRoom = 6;
            int NumberOfRoomsRent = 0;
            DateTime beginTime = new DateTime(2017, 1, 18);
            DateTime endTime = new DateTime(2017, 1, 22);
            Reception reception = new Reception();
            reception.SayHello();

            Room Room1 = new FamillyRoom(200, beginTime, endTime);
            NumberOfRoomsRent++;
            Room1.CalculatePrice(200,1, beginTime, endTime, 1);

            Room Room2 = new DoubleSingleRoom(120, new DateTime(2017, 2, 22), new DateTime(2017, 2, 26));
            NumberOfRoomsRent++;
            Room2.CalculatePrice(120, 2, new DateTime(2017, 2, 22), new DateTime(2017, 2, 26),1);

            reception.CheckRoom(NumberOfRoom-NumberOfRoomsRent);

            reception.RoomPosition();

            
        }
    }
}
