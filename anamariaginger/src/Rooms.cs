using System;
using System.Collections.Generic;
using System.Text;

namespace anamariaginger
{
    public abstract class  Rooms
    {
        public decimal price;
        public int roomnr;
        public int nrnights;

        public Rooms() { }
        public abstract decimal get_price_to_pay();
        public Rooms(int roomnr, int nrnights)
        {
            this.roomnr = roomnr;
            this.nrnights = nrnights;
        }
    }
}
