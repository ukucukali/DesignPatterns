
using Encapsulation.ExampleOne;
using Encapsulation.ExampleTwo;


#region Example One

BankAccount account = new BankAccount(1000);
account.DisplayBalance();

account.Deposit(500);
account.DisplayBalance();

account.Withdraw(200);
account.DisplayBalance();

// Withdrawal amount exceeds balance, balance will be 0 
account.Withdraw(1500); 
account.DisplayBalance();

#endregion

Console.WriteLine("\n*****\n");

#region Example Two

Car myCar = new Car("Toyota", "Corolla", 2010);
myCar.StartEngine();
myCar.DisplayInfo();

Console.WriteLine();

Car friendCar = new Car("Honda", "Civic", 2023);
friendCar.DisplayInfo();

friendCar.StartEngine();
friendCar.StopEngine();
friendCar.DisplayInfo();

#endregion