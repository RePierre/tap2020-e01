using System;


public abstract class Elements
{
    public decimal Price;
    public string Location;
    public decimal Discount;
    public int Nights;

}

class Program:Elements
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("FamilyCamera -> go to family camera details");
        Console.WriteLine("DoubleSimpleCamera -> go to double simple camera details");
        Console.WriteLine("DoubleMountainCamera -> go to double camera with mountain view details");
        Console.WriteLine("Mansard -> go to mansard details");
        Console.WriteLine("Option: ");
        String option = Console.ReadLine();
        switch (option) {
            case "FamilyCamera":
                FamilyCamera FC = new FamilyCamera("FamilyCamera - parter", 200m, 0.2m,4);
                Console.WriteLine("");
                Console.WriteLine(FC.Location + " will cost " + FC.Price + "RON/night");
                if (FC.Nights > 3)
                {
                    Console.WriteLine(FC.Location + " for " + FC.Nights + " nights will cost " + (FC.Price - (FC.Price * FC.Discount)) + "RON/night (20% discount)");
                    Console.WriteLine("with a total price of:  " + ((FC.Price - (FC.Price * FC.Discount))) * FC.Nights + "RON");
                }
                else
                    Console.WriteLine(FC.Location + " for " + FC.Nights + " nights will cost " + FC.Price * FC.Nights + "RON");
                break;

            case "DoubleSimpleCamera":
                DoubleSimpleCamera DSC = new DoubleSimpleCamera("DoubleSimpleCamera - Camera 1 (floor1)", 120m, 0.2m, 3);
                Console.WriteLine("");
                Console.WriteLine(DSC.Location+ " will cost " + DSC.Price + "RON/night");
                if (DSC.Nights > 3)
                {
                    Console.WriteLine(DSC.Location +" for " + DSC.Nights + " nights will cost " + (DSC.Price-(DSC.Price * DSC.Discount) ) + "RON/night (20% discount)");
                    Console.WriteLine("with a total price of:  " + ((DSC.Price - (DSC.Price * DSC.Discount)) * DSC.Nights) + "RON");
                }
                else
                    Console.WriteLine(DSC.Location + " for " + DSC.Nights + " nights will cost " + DSC.Price * DSC.Nights + "RON");
                break;

            case "DoubleMountainCamera":
                DoubleMountainCamera DMC = new DoubleMountainCamera("DoubleMountainCamera - Camera 1 (floor1)", 150m, 0.2m, 3);
                DoubleMountainCamera DMC2 = new DoubleMountainCamera("DoubleMountainCamera - Camera 2 (floor1)", 150m, 0.2m, 4);
                Console.WriteLine("");
                Console.WriteLine(DMC.Location + " will cost " + DMC.Price + "RON/night");
                if (DMC.Nights > 3)
                {
                    Console.WriteLine(DMC.Location + " for " + DMC.Nights + " nights will cost " + (DMC.Price - (DMC.Price * DMC.Discount)) + "RON/night (20% discount)");
                    Console.WriteLine("with a total price of:  " + ((DMC.Price - (DMC.Price * DMC.Discount)) * DMC.Nights) + "RON");
                }
                else
                    Console.WriteLine(DMC.Location + " for " + DMC.Nights + " nights will cost " + DMC.Price * DMC.Nights + "RON");


                Console.WriteLine("");
                Console.WriteLine(DMC2.Location + " will cost " + DMC2.Price + "RON/night");
                if (DMC2.Nights > 3)
                {
                    Console.WriteLine(DMC2.Location + " for " + DMC2.Nights + " nights will cost " + (DMC2.Price - (DMC2.Price * DMC2.Discount)) + "RON/night (20% discount)");
                    Console.WriteLine("with a total price of:  " + ((DMC2.Price - (DMC2.Price * DMC2.Discount))) * DMC2.Nights + "RON");
                }
                else
                    Console.WriteLine(DMC2.Location + " for " + DMC2.Nights + " nights will cost " + DMC2.Price * DMC2.Nights + "RON");
                break;

            case "Mansard":
                Mansard mansard = new Mansard("Mansard - Camera 1 (floor1)", 100m, 0.2m, 21);
                Mansard mansard2 = new Mansard("Mansard - Camera 2 (floor1)", 100m, 0.2m, 2);
                Console.WriteLine("");
                Console.WriteLine(mansard.Location + " will cost " + mansard.Price + "RON/night");
                if (mansard.Nights > 3)
                {
                    Console.WriteLine(mansard.Location + " for " + mansard.Nights + " nights will cost " + (mansard.Price - (mansard.Price * mansard.Discount)) + "RON/night (20% discount)");
                    Console.WriteLine("with a total price of:  " + ((mansard.Price - (mansard.Price * mansard.Discount)) * mansard.Nights) + "RON");
                }
                else
                    Console.WriteLine(mansard.Location + " for " + mansard.Nights + " nights will cost " + mansard.Price * mansard.Nights + "RON");


                Console.WriteLine("");
                Console.WriteLine(mansard2.Location + " will cost " + mansard.Price + "RON/night");
                if (mansard2.Nights > 3)
                {
                    Console.WriteLine(mansard2.Location + " for " + mansard2.Nights + " nights will cost " + (mansard2.Price - (mansard2.Price * mansard2.Discount)) + "RON/night (20% discount)");
                    Console.WriteLine("with a total price of:  " + ((mansard2.Price - (mansard2.Price * mansard2.Discount))) * mansard2.Nights + "RON");
                }
                else
                    Console.WriteLine(mansard2.Location + " for " + mansard2.Nights + " nights will cost " + mansard2.Price * mansard2.Nights + "RON");
                break;
            default:
                break;
        }
        }
    }

