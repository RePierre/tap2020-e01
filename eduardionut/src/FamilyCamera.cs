using System;
using System.Collections.Generic;
using System.Text;

public class FamilyCamera : Elements
{
    public FamilyCamera(string Location, decimal Price, decimal Discount,decimal Nights)
    {
        this.Location = Location;
        this.Price = Price;
        this.Discount = Discount;
        this.Nights = Nights;
    }
}
