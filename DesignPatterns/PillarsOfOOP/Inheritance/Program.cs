
using Inheritance.ExampleOne;
using Inheritance.ExampleTwo;


#region Example One

Car car = new Car("Toyota", "Camry", 4);
car.Start();
car.Accelerate();
car.Stop();

Console.WriteLine();

Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", false);
motorcycle.Start();
motorcycle.Wheelie();
motorcycle.Stop();

#endregion

Console.WriteLine("\n*********\n");

#region Example Two

BankAccount savingsAccount = new SavingsAccount("SA-12345", 1000, 0.03m);
savingsAccount.Deposit(500);
savingsAccount.Withdraw(200);
savingsAccount.DisplayAccountInfo();

Console.WriteLine();

BankAccount checkingAccount = new CheckingAccount("CA-12345", 2000, 500);
checkingAccount.Deposit(100);
checkingAccount.Withdraw(3000);
checkingAccount.DisplayAccountInfo();

#endregion