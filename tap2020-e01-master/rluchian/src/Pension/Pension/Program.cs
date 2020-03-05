using System;

namespace Pension
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyRoom Room1 = new FamilyRoom(1,new DateTime(2020,03,24), new DateTime(2020, 03, 30));
            Console.WriteLine("You have requested the only family room");
            decimal tax1=Reception.StayTax(Room1.number,Room1.Begin, Room1.End);
            Console.WriteLine("The tax for the requested stay and room: " + tax1 + "RON");
            Single Room5 = new Single(5, new DateTime(2020, 04, 24), new DateTime(2020, 04, 30));
            Console.WriteLine("You have requested one of the single rooms");
            decimal tax5=Reception.StayTax(Room1.number, Room1.Begin, Room1.End);
            Console.WriteLine("The tax for the requested stay and room: " + tax5 + "RON");

        }
    }
}
