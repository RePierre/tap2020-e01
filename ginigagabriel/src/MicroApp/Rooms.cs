using System;
using System.Collections.Generic;
using System.Text;

namespace MicroApp
{
    public class Rooms
    {
        private static Rooms aux;

        private Rooms() { }

        public static Rooms AUX
        {
            get
            {
                if (aux == null)
                {
                    aux = new Rooms();
                }
                return aux;
            }
        }

        public void addRoomInList()
        {
            Program.listofroom.Add(1, 200);
            Program.listofroom.Add(2, 120);
            Program.listofroom.Add(3, 120);
            Program.listofroom.Add(4, 150);
            Program.listofroom.Add(5, 100);
            Program.listofroom.Add(6, 100);
        }

        public double showPrice(int nr, DateTime initial, DateTime final)
        {
            int duration = final.DayOfYear - initial.DayOfYear;
            if (duration < 3)
                switch (nr)
                {
                    case 1:
                        return duration * 200;
                        break;
                    case 2:
                        return duration * 120;
                        break;
                    case 3:
                        return duration * 120;
                        break;
                    case 4:
                        return duration * 150;
                        break;
                    case 5:
                        return duration * 100;
                        break;
                    case 6:
                        return duration * 100;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            else
                switch (nr)
                {
                    case 1:
                        return duration * 200 - 0.2 * (duration * 200);
                        break;
                    case 2:
                        return duration * 120 - 0.2 * (duration * 120);
                        break;
                    case 3:
                        return duration * 120 - 0.2 * (duration * 120);
                        break;
                    case 4:
                        return duration * 150 - 0.2 * (duration * 150);
                        break;
                    case 5:
                        return duration * 100 - 0.2 * (duration * 100);
                        break;
                    case 6:
                        return duration * 100 - 0.2 * (duration * 100);
                        break;
                    default: Console.WriteLine("Error"); break;

                };
            return 0;
        }
    }
}
