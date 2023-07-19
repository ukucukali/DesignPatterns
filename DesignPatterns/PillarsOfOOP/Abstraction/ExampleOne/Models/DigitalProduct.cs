namespace Abstraction.ExampleOne.Models;

public class DigitalProduct : Product
{   
    // sending information to base Product class
    public DigitalProduct(string name, decimal price) : base(name, price)
    {
    }

    // for digital product there is no shipment cost so we return 0
    public override decimal CalculateShippingCost() => 0;
}