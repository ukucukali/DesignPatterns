namespace Abstraction.ExampleOne.Models;

public abstract class Product
{
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public Product(string name, decimal price )
    {
        Name = name;
        Price = price;
    }

    // Abstract method to calculate the shipping cost
    public abstract decimal CalculateShippingCost();
}