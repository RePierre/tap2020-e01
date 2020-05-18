using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluare
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera1 = new Camera("1");
            Camera camera2 = new Camera("5");
            new Receptie(camera1, 3);
            new Receptie(camera2, 9);
            Console.ReadKey();
        }
    }
}
