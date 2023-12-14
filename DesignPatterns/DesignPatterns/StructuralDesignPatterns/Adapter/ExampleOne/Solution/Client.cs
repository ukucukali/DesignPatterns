using Adapter.ExampleOne.Solution.Interfaces;

namespace Adapter.ExampleOne.Solution;

public class Client
{
    public void MakeRequest(ITarget target)
    {
        Console.WriteLine("Client making a request");
        target.Request();
    }
}