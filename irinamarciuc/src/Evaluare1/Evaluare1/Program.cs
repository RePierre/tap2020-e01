using System;

namespace Evaluare1
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyRoom f = new FamilyRoom(new DateTime(2013, 1, 23), new DateTime(2013, 1, 27));
            Console.WriteLine("Room price: " + f.FinalPrice(1,new DateTime(2013, 1, 23), new DateTime(2013, 1, 27)) + "\n");

            SimpleDouble sd = new SimpleDouble(new DateTime(2013, 1, 23), new DateTime(2013, 1, 27));
            Console.WriteLine("Double room price :" + sd.FinalPrice(2, new DateTime(2013, 1, 23), new DateTime(2013, 1, 27)) + "\n");

            SpecialDouble spd = new SpecialDouble(new DateTime(2013, 1, 23), new DateTime(2013, 1, 27));
            Console.WriteLine("Special double room price: " + spd.FinalPrice(5, new DateTime(2013, 1, 23), new DateTime(2013, 1, 27)) + "\n");

            Mansard m = new Mansard(new DateTime(2013, 1, 23), new DateTime(2013, 1, 27));
            Console.WriteLine("Mansard price: " + m.FinalPrice(6,new DateTime(2013, 1, 23), new DateTime(2013, 1, 27)) + "\n");
        }
    }
}
