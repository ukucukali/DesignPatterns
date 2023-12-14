using Adapter.ExampleOne.Solution.Interfaces;

namespace Adapter.ExampleOne.Solution;

public class ObjectAdapter : ITarget
{
    private readonly OldSystem _oldSystem;

    public ObjectAdapter(OldSystem oldSystem)
    {
        _oldSystem = oldSystem;
    }
    
    public void Request() => _oldSystem.SpecificRequest();
}