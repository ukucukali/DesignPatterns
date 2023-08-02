#region Example One

using Polymorphism.ExampleOne;
using Polymorphism.ExampleTwo.CompileTimePolymorphism_StaticPolymorphism;
using Polymorphism.ExampleTwo.RunTimePolymorphism_DynamicPolymorphism;

//All the classes can be treated as an employee but their outcomes are different.So in this way we can easily maintain extend or reuse classes without major code brake.
Employee fullTimeEmployee = new PartTimeEmployee("John Doe", 160, 20.0m);
Employee partTimeEmployee = new FullTimeEmployee("Jane Smith", 1200.0m);
Employee contractEmployee = new ContractEmployee("Mike Johnson", 5000.0m);

Console.WriteLine($"Full-Time Employee Salary: ${fullTimeEmployee.CalculateSalary()}");
Console.WriteLine($"Part-Time Employee Salary: ${partTimeEmployee.CalculateSalary()}");
Console.WriteLine($"Contract Employee Salary: ${contractEmployee.CalculateSalary()}");

#endregion

Console.WriteLine("\n================\n");

#region Example Two

#region Static Polymorphism

Calculator calculator = new Calculator();

// Compile-time polymorphism using method overloading
int result1 = calculator.Add(5, 10);
int result2 = calculator.Add(2, 3, 6);
double result3 = calculator.Add(3.5, 2.1);
int result4 = calculator.Add(1, 2, 3, 4, 5);

Console.WriteLine($"Result 1: {result1}"); // Output: Result 1: 15
Console.WriteLine($"Result 2: {result2}"); // Output: Result 2: 11
Console.WriteLine($"Result 3: {result3}"); // Output: Result 3: 5.6
Console.WriteLine($"Result 4: {result4}"); // Output: Result 4: 15

#endregion

Console.WriteLine("\n--------------\n");

#region Dynamic Polymorphism

Vehicle car = new Car();
Vehicle motorcycle = new Motorcycle();
Vehicle truck = new Truck();

car.DisplayFuelType(); // Output: Fuel type: Gasoline
motorcycle.DisplayFuelType(); // Output: Fuel type: Petrol
truck.DisplayFuelType(); // Output: Fuel type: Diesel

#endregion

#endregion