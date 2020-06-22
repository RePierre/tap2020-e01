using System;
using System.Collections.Generic;
using System.Text;

namespace Pension
{
    public class Reception
    {
        decimal StayTax(int roomNumber, DateTime Begin, DateTime End)
        {
            decimal tax = 0;
            int duration = End.Day - Begin.Day;
            bool off = duration > 3;
            switch (roomNumber)
            {
                case 1://For family Room
                    if (off)
                        tax = duration * 200m * 0.8m;
                    else
                        tax = duration * 200m;
                    break;
                case 2://For Double Simple view Room
                    if (off)
                        tax = duration * 120m * 0.8m;
                    else
                        tax = duration * 120m;
                    break;

                case 3://For double mountain view room
                    if (off)
                        tax = duration * 150m * 0.8m;
                    else
                        tax = duration * 150m;
                    break;
                case 4://For double mountain view room
                    if (off)
                        tax = duration * 150m * 0.8m;
                    else
                        tax = duration * 150m;
                    break;
                case 5://for single room
                    if (off)
                        tax = duration * 150m * 0.8m;
                    else
                        tax = duration * 150m;
                    break;
                case 6://for single room
                    if (off)
                        tax = duration * 150m * 0.8m;
                    else
                        tax = duration * 150m;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return tax;
        }
    }
}
