using System.Threading.Channels;

namespace DependencyInversionPrinciple.Models.ExampleOne.GoodPractice;

public interface ILogger
{
    void Log(string message);
}