namespace Builder.ExampleTwo.GoodPractice;

public class House
{
    public string Foundation { get; set; }

    public string Walls { get; set; }

    public string Roof { get; set; }

    public string Windows { get; set; }

    public string Doors { get; set; }

    public string Garden { get; set; }

    public string SwimmingPool { get; set; }

    public void Display()
    {
        Console.WriteLine($"Foundation: {Foundation}");
        Console.WriteLine($"Walls: {Walls}");
        Console.WriteLine($"Roof: {Roof}");
        Console.WriteLine($"Windows: {Windows}");
        Console.WriteLine($"Doors: {Doors}");
        Console.WriteLine($"Garden: {Garden}");
        Console.WriteLine($"Swimming Pool: {SwimmingPool}");
    }
}