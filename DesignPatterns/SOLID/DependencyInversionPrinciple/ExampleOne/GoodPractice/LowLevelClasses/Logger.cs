using DependencyInversionPrinciple.ExampleOne.GoodPractice.LowLevelClasses.Interfaces;

namespace DependencyInversionPrinciple.ExampleOne.GoodPractice.LowLevelClasses;

public class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine($"Logging: {message}");
}