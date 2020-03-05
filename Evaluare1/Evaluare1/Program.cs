using System;

namespace Evaluare1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bucovina Guest House!");
            Console.WriteLine("Select number of which type of room do you prefer to stay?(1->Family Room/2->Double Room/3,4->Double Room Mountain View/5,6->Attic Room)");
            DoubleRoom dr = new DoubleRoom(2, 5);
            Console.WriteLine("Camera "+dr.numberRoom+" Zile rezervate: "+dr.daysReserved+" Pret: "+dr.calculateTotalPrice());
            
        }
    }
}
