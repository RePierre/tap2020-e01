using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Reception
    {

        public Dictionary<string, string> dict = new Dictionary<string, string>()
                                                {
                                                    {"A","camerafamilie"},
                                                    {"B", "cameradublasimpla"},
                                                    {"C","cameradublacuvedere"},
                                                    { "D","cameramansarda"}
                                                };
        public Decimal priceCalculator(Room room, int nrnight)
        {
            if ((room.type == dict["A"]) && room.rezervat == false)
            {
                if (nrnight >= 3) { return (200 - 20 / 100 * 200); }
                else return 200;
            }
            if (room.type == dict["B"] && (room.rezervat == false))
            {
                if (nrnight >= 3) { return (150 - 20 / 100 * 150); }
                else return 150;
            }
            if (room.type == dict["C"] && room.rezervat == false)
            {
                if (nrnight >= 3) { return (120 - 20 / 100 * 120); }
                else return 120;
            }
            if (room.type == dict["D"] && room.rezervat == false)
            {
                if (nrnight >= 3) { return (100 - 20 / 100 * 100); }
                else return 100;
            }
            return 0;


        }

    }
}
