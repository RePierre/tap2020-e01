using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Room
    {
       public  String type {  get; set; }
      public  Decimal price{get;set;}
       public int numberroom { get; set; }
    public    int floor { get; set; }
        public bool rezervat { get; set; }
      public  Room(String type, Decimal price, int numberroom,bool rezervat) {
            this.type = type;
            this.price = price;
            this.numberroom = numberroom;
            this.floor = floor;
            this.rezervat = rezervat;
        }
    }
}
