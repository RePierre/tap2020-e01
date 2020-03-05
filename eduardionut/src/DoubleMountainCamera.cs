using System;
using System.Collections.Generic;
using System.Text;

public class DoubleMountainCamera : Elements
{
    public DoubleMountainCamera(string Location, decimal Price, decimal Discount, int Nights)
    {
        this.Location = Location;
        this.Price = Price;
        this.Discount = Discount;
        this.Nights = Nights; 
    }
}
