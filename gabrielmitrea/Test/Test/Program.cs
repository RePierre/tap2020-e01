using System;

namespace Test
{
    public class familyRoom : Reservation
    {
        public override decimal totalPrice(decimal price,int numberOfNights,int numberOfRooms)
        {
            if(numberOfRooms>1)
            { throw  new InvalidOperationException("Not enought family rooms available"); }
            else
            return 200 * numberOfNights*numberOfRooms;
        }
    }
    public class doubleRoom : Reservation
    {
        public override decimal totalPrice(decimal price, int numberOfNights,int numberOfRooms)
        {
            if (numberOfRooms > 1)
            { throw new InvalidOperationException("Not enought family rooms available"); }
            else
                return 120 * numberOfNights * numberOfRooms;
        }
    }
    public class doubleWithView : Reservation
    {
        public override decimal totalPrice(decimal price, int numberOfNights, int numberOfRooms)
        {
            if (numberOfRooms > 2)
            { throw new InvalidOperationException("Not enought family rooms available"); }
            else
                return 150 * numberOfNights * numberOfRooms;
        }
    }
    public class singleRoom : Reservation
    {
        public override decimal totalPrice(decimal price, int numberOfNights, int numberOfRooms)
        {
            if (numberOfRooms > 2)
            { throw new InvalidOperationException("Not enought family rooms available"); }
            else
                return 100 * numberOfNights * numberOfRooms;
        }
    }
    
    public abstract class Reservation
    {
        public decimal priceRoom1 { get; private set; }
        public decimal priceRoom2 { get; private set; }
        public decimal priceRoom3 { get; private set; }
        public decimal priceRoom4 { get; private set; }
        public int NumOfNights { get; private set; }
        public int NumOfRooms { get; private set; }
        public int RoomNumber { get; private set; }
        public string Level { get; private set; }
        public void Reserve(int numberOfNights,decimal price, string level, int numberOfRooms)
        {
            
            price = totalPrice(price,numberOfNights,numberOfRooms);
            this.priceRoom1 = price;
            this.Level = level;
            this.NumOfRooms = numberOfRooms;
            this.NumOfNights = numberOfNights;
           
        }
        public abstract decimal totalPrice(decimal price, int numberOfNights,int numberOfRooms);

    }
    class Program
    {
        static void Main(string[] args)
        {
            var room1 = new familyRoom();
            var room2 = new doubleRoom();
            var room3 = new doubleWithView();
            var room4 = new singleRoom();
            room1.Reserve(3, 200, "1st Floor",1);
            room2.Reserve(3, 120, "2nd Floor",1);
            room3.Reserve(3, 150, "2nd Floor",2);
            room4.Reserve(3, 100, "3rd Floor",2);
            Console.WriteLine("Number of nights: "+room1.NumOfNights + "\r\n"+"Price of the room number 1 is : "+ room1.priceRoom1 + "\r\n"+ "The level of the room is: "+room1.Level+"\r\n"+"Number of rooms: "+room1.NumOfRooms+"\r\n" );
            Console.WriteLine("Number of nights: " + room2.NumOfNights + "\r\n" + "Price of the room number 2 is : " + room2.priceRoom1 + "\r\n" + "The level of the room is: " + room2.Level + "\r\n" + "Number of rooms: " + room2.NumOfRooms + "\r\n");
            Console.WriteLine("Number of nights: " + room3.NumOfNights + "\r\n" + "Price of the room number 3 is : " + room3.priceRoom1 + "\r\n" + "The level of the room is: " + room3.Level + "\r\n" + "Number of rooms: " + room3.NumOfRooms + "\r\n");
            Console.WriteLine("Number of nights: " + room4.NumOfNights + "\r\n" + "Price of the room number 4 is : " + room4.priceRoom1 + "\r\n" + "The level of the room is: " + room4.Level + "\r\n" + "Number of rooms: " + room4.NumOfRooms + "\r\n");
            Console.WriteLine();
            decimal totalpricee = room1.priceRoom1 + room2.priceRoom1 + room3.priceRoom1 + room4.priceRoom1;
            Console.WriteLine("Total price for reseservation is from 1st January-4 January is: "+totalpricee);
        }
    }
}
