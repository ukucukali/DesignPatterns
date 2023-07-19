
using Abstraction.ExampleOne.Models;
using Abstraction.ExampleTwo.Models;

#region Example One

Console.WriteLine("****** Example one ******\n");

var physicalProduct = new PhysicalProduct("Book", 19.99m);
physicalProduct.Ship();

var digitalProduct = new DigitalProduct("eBook", 9.99m);
decimal shippingCost = digitalProduct.CalculateShippingCost();
Console.WriteLine($"Shipping Cost: ${shippingCost:F2}");

#endregion


#region Example Two
Console.WriteLine("\n****** Example Two ******\n");

var fullTimeEmployee = new FullTimeEmployee("John Doe", "FT-123", 5000);
fullTimeEmployee.DisplayEmployeeDetails();

var partTimeEmployee = new PartTimeEmployee("Jane Smith", "PT-123", 20, 120);
partTimeEmployee.DisplayEmployeeDetails();

#endregion

