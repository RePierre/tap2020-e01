using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace MicroApp
{
    class Program
    {
        public static Dictionary<int, double> listofroom = new Dictionary<int, double>();
        static void Main(string[] args)
        {
            Rooms.AUX.addRoomInList();
            Reception.WRITE.Writer(1, new DateTime(2020, 1, 18), new DateTime(2020, 1, 22));
            Reception.WRITE.Writer(5, new DateTime(2020, 1, 18), new DateTime(2020, 1, 20));
        }
    }
}
