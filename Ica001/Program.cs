using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("camerafamilie", 120, 1,false);
            Room room2 = new Room("cameradublasimpla", 150, 2,false);
            Room room3 = new Room("cameradublacuvedere", 200, 3,false);
            Room room4 = new Room("cameramansarda", 100, 4,false);
            Room room5 = new Room("camerafamilie", 120, 5,true);
            Room room6 = new Room("camerafamilie", 220, 6,true);
            //preturile nu sunt puse corespunzator...
           

          //  Pensiune pensiune(rooms);
           
            Reception reception = new Reception();
            Console.WriteLine(reception.priceCalculator(room1, 2));
            
            Console.ReadLine();
        }
    }
}
