using Builder.ExampleOne;
using Builder.ExampleOne.GoodPractice;
using Builder.ExampleTwo.BadPractice;
using Builder.ExampleTwo.GoodPractice.Builder;
using Builder.ExampleTwo.GoodPractice.Director;

/*
 * Define all the necessary construction steps for building all available product representations.
 * Create builder interface which will be contain the construction steps.
 * Create concrete builders that will implement the construction steps according to product
 * Create director class which will be interact with client. Director contains specifications of specific products and can be reused.
 * At the end products will be created. Products constructed by different builders don’t have to belong to the same class hierarchy or interface.
 */

#region ExampleOne (without director class)

#region BadPractice

// computer class instances gets many configuration at the same time, because of that creating instances with various configurations becomes less maintainable and less readable.
Computer computerWithoutBuilder = new Computer()
{
    CPU = "Intel Core i7",
    RAM = "16GB",
    Storage = "512GB SSD",
    GraphicsCard = "NVIDIA GeForce RTX 3080"
};

Console.WriteLine("Computer -1-");
computerWithoutBuilder.DisplayInfo();

computerWithoutBuilder = new Computer
{
    CPU = "AMD Ryzen 9", 
    RAM = "32GB",
    Storage = "1TB NVMe SSD", 
    GraphicsCard = "NVIDIA GeForce RTX 3070"
};

Console.WriteLine("\nComputer -2-");
computerWithoutBuilder.DisplayInfo();

#endregion

Console.WriteLine("\n------------------------\n");

#region GoodPractice
Console.WriteLine("Computer -1-");
var computerWithBuilder = new ComputerBuilder()
                          .SetCpu("Intel Core i5")
                          .SetRam("8GB")
                          .SetStorage("1TB")
                          .SetGraphicsCard("NVIDIA GeForce RTX 3050")
                          .Build();

computerWithBuilder.DisplayInfo();

Console.WriteLine("\nComputer -2-");
computerWithBuilder = new ComputerBuilder()
                      .SetCpu("AMD Ryzen 7")
                      .SetRam("16GB")
                      .SetStorage("256GB")
                      .SetGraphicsCard("NVIDIA GeForce RTX 3050")
                      .Build();

computerWithBuilder.DisplayInfo();

#endregion

#endregion

Console.WriteLine("\n========================================\n");

#region Example Two (with director class)

#region Bad Practice

House houseWithoutBuilder = new House
{
    Foundation = "Concrete",
    Walls = "Brick",
    Roof = "Shingles",
    Windows = "Glass",
    Doors = "Wood",
    Garden = "No garden",
    SwimmingPool = "No swimming pool"
};

houseWithoutBuilder.Display();
Console.WriteLine("\n-------------------------\n");

houseWithoutBuilder = new House
{
    Foundation = "Wood",
    Walls = "Wood",
    Roof = "Tiles",
    Windows = "Glass",
    Doors = "Steel",
    Garden = "No garden",
    SwimmingPool = "No swimming pool"
};
houseWithoutBuilder.Display();

#endregion
Console.WriteLine("\n============================\n");
#region Good Practice

var engineer = new ConstructionEngineer(new CottageBuilder());
Builder.ExampleTwo.GoodPractice.House house = engineer.BuildHouse();
Console.WriteLine("Cottage:");
house.Display();

Console.WriteLine("\n---------------------------\n");

engineer = new ConstructionEngineer(new MansionBuilder());
house = engineer.BuildHouse();
Console.WriteLine("Mansion:");
house.Display();

#endregion

#endregion