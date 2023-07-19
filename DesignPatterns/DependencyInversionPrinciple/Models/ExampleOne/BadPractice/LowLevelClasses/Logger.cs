using System.Threading.Channels;

namespace DependencyInversionPrinciple.Models.ExampleOne.BadPractice;

public class Logger
{
    public void Log(string message) => Console.WriteLine($"Logging: {message}");
}