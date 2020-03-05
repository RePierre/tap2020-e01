using System;

namespace BucovinaBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            string roomType;
            Console.WriteLine("Available Rooms: \n\n" +
                "1. Family Room - Price: 200 RON/Night \n" +
                "2. Double Room(Simple) - Price: 120 RON/Night \n" +
                "3. Double Room(Mountain View) - Price: 150 RON/Night \n" +
                "4. Attic Room - Price: 100 RON/Night" +
                "Choose Room Type: ");
            roomType = Console.ReadLine();

            Console.WriteLine("Choose Check-In Date: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime startDate);

            Console.WriteLine("Choose Check-Out Date: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime endDate);

            Reception reception = new Reception();
            decimal reservationPrice = reception.CalculateReservationPrice(roomType, startDate, endDate);
            Console.WriteLine("Total price for selected reservation is: " + reservationPrice);
        }
    }
}
