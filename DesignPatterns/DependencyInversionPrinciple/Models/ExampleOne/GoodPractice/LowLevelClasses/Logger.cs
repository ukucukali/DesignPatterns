using System.Threading.Channels;

namespace DependencyInversionPrinciple.Models.ExampleOne.GoodPractice;

public class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine($"Logging: {message}");
}