using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace MicroApp
{
     class Reception
    {

        private static Reception write;

        private Reception() { }

        public static Reception WRITE
        {
            get
            {
                if (write == null)
                {
                    write = new Reception();
                }
                return write;
            }
        }

        public void Writer(int nr, DateTime initial, DateTime final)
        {
            Console.WriteLine(Convert.ToString(Rooms.AUX.showPrice(nr, initial, final)));
        }
    }
}
