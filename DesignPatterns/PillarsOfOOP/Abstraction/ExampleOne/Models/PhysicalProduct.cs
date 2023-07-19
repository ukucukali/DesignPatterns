using Abstraction.ExampleOne.Interfaces;

namespace Abstraction.ExampleOne.Models;

public class PhysicalProduct : Product, IShippable
{
    // sending information to base Product class
    public PhysicalProduct(string name, decimal price) : base(name, price)
    {
    }

    public override decimal CalculateShippingCost()
    {
        // Calculate shipping cost based on weight, distance, etc.
        return 5.99m; // for the example it is fixed a value
    }
    
    //IShippable interface implemented only for this class because it has shipment operations
    public void Ship() => Console.WriteLine($"Shipping {Name} - Cost: ${CalculateShippingCost()}");
}