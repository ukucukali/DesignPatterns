using Prototype.ExampleTwo.Solution.Interface;

namespace Prototype.ExampleTwo.Solution;

public class SmartPhone : IPhonePrototype
{
    public string OS { get; private set; }
    
    public int Storage { get; private set; }
    
    public string Camera { get; private set; }
    
    public double ScreenSize { get; private set; }
    
    public void ConfigureOS(string os)
    {
        OS = os;
    }

    public void SetStorage(int storage)
    {
        Storage = storage;
    }

    public void SetCamera(string camera)
    {
        Camera = camera;
    }

    public void SetScreenSize(double size)
    {
        ScreenSize = size;
    }

    public IPhonePrototype Clone() => (IPhonePrototype)MemberwiseClone();
    
    public void DisplayDetails()
    {
        Console.WriteLine($"OS: {OS}");
        Console.WriteLine($"Storage: {Storage}GB");
        Console.WriteLine($"Camera: {Camera}");
        Console.WriteLine($"Screen Size: {ScreenSize}");
    }
}