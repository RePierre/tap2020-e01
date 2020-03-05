using System;
using System.Collections.Generic;
using System.Text;


    abstract class Room
    {
    public decimal Price { get; private set; }
    public void Selling_Price(decimal amount)
    {
        var money = CalculatePrice(amount);
        amount = amount + money;
        if (Price <= amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        this.Price -= amount;
    }
    protected abstract decimal CalculatePrice(decimal amount);
    }

