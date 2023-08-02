namespace Polymorphism.ExampleTwo.RunTimePolymorphism_DynamicPolymorphism;

public class Truck : Vehicle
{
    public override void DisplayFuelType()
    {
        Console.WriteLine("Fuel type: Diesel");
    }
}