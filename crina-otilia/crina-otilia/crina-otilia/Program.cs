using System;

namespace crina_otilia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("room number 1- camera de familie");
            Console.WriteLine("room number 2 and 3- camera dubla cu vedere la munte");
            Console.WriteLine("room number 4- camera dubla fara vedere la munte");
            Console.WriteLine("room number 5 and 6- camera la mansarda");

            string val;
            Console.Write("Enter the number of the room : ");
            val = Console.ReadLine();
            int a = Convert.ToInt32(val);
            while (a < 1 && a > 6) {
                Console.Write("Enter the number of the room : ");
                val = Console.ReadLine();
                a = Convert.ToInt32(val);
            }

            string day;
            Console.Write("Enter the day of checkin : ");
            day = Console.ReadLine();
            int day1 = Convert.ToInt32(day);

            string month;
            Console.Write("Enter the month of checkin : ");
            month = Console.ReadLine();
            int month1 = Convert.ToInt32(month);

            string year;
            Console.Write("Enter the year of checkin : ");
            year = Console.ReadLine();
            int year1 = Convert.ToInt32(year);

            DateTime checkin = new DateTime(year1, month1, day1);

            string day2;
            Console.Write("Enter the day of checkout : ");
            day2= Console.ReadLine();
            int day12 = Convert.ToInt32(day2);

            string month2;
            Console.Write("Enter the month of checkout : ");
            month2 = Console.ReadLine();
            int month12 = Convert.ToInt32(month2);

            string year2;
            Console.Write("Enter the year of checkout : ");
            year2 = Console.ReadLine();
            int year12 = Convert.ToInt32(year2);

            DateTime checkout = new DateTime(year12, month12, day12);

            decimal total;
            total=Reception.Price(a,checkin,checkout);
            Console.WriteLine(total);

            decimal exemplul1, exemplul2;
            DateTime checkinEx1 = new DateTime(2020, 3, 2);
            DateTime checkoutEx1= new DateTime(2020, 3, 10);
            DateTime checkinEx2 = new DateTime(2020, 4, 22);
            DateTime checkoutEx2 = new DateTime(2020, 4, 24);
            exemplul1 = Reception.Price(1, checkinEx1, checkoutEx1);
            exemplul2 = Reception.Price(5, checkinEx2, checkoutEx2);

            Console.Write("Doua exemple sugestive: ");
            


        }
    }
}
