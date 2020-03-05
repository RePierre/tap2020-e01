using System;
using System.Collections.Generic;
using System.Text;

namespace Mansion
{
    class Reception
    { //WE HAVE 6 rooms for rent
        string message;
        string choise;
        int RoomLeft;
        public void RespondRequest() { 
        }
        public void SayHello() {
            string response="Hello guys \n";
            string val;
            Console.Write("Start a conversation: \n");
            val = Console.ReadLine();

            if (val.Equals("Hello \n")) {
                Console.WriteLine(response);
            }


        }

        public void RoomPosition() {
            string val;
            string view = "mountain";
            string viewChoise;
            Console.Write("Which room do you want? \n");
            val = Console.ReadLine();
            if (val.Equals("ground floor"))
            {
                Console.WriteLine("We have only a room and this room is perfect for a familly. It can be yours for " +
                    "the price of 200 RON per night \n");
            }
            else if (val.Equals("floor"))
            {
                Console.WriteLine("We have 3 rooms here and among them we have 2 with mountain view \n");
                Console.WriteLine("Which one do you want? \n");


                viewChoise = Console.ReadLine();
                if (viewChoise.Equals(view))
                {
                    Console.WriteLine("Good choice you've made!");
                    Console.WriteLine("The price for this is 150 RON per night");
                }
                else
                {
                    Console.WriteLine("Ok, let's go to see the room!");
                    Console.WriteLine("The price for this is 120 RON per night");
                }
            }
            else {
                Console.WriteLine("We have 2 garret room");

            }

        }
        static void Main(string[] args) { 
        
        }

        public Reception() {
            Console.WriteLine("Welcome to Bucovina");
        }
        public void CheckRoom(int NumberLeft) {
            bool RoomRent = true;
            if (NumberLeft == 0)
                Console.WriteLine("We don't have a room for you, sorry!");
            else {
                while (NumberLeft != 0)
                {
                    Console.WriteLine("We still have " + NumberLeft + " rooms");
                    if (RoomRent == true)
                        NumberLeft--;

                }
                    
            }
        }

    }
}
