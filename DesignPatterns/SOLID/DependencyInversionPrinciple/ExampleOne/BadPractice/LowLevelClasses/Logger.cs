namespace DependencyInversionPrinciple.ExampleOne.BadPractice.LowLevelClasses;

public class Logger
{
    public void Log(string message) => Console.WriteLine($"Logging: {message}");
}