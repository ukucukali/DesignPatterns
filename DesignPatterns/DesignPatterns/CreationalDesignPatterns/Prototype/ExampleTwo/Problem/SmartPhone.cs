namespace Prototype.ExampleTwo.Problem;

public class SmartPhone
{
    public string OS { get; set; }

    public int Storage { get; set; }

    public string Camera { get; set; }

    public double ScreenSize { get; set; }

    public SmartPhone(string os, int storage, string camera, double screenSize)
    {
        OS = os;
        Storage = storage;
        Camera = camera;
        ScreenSize = screenSize;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"OS: {OS}");
        Console.WriteLine($"Storage: {Storage}GB");
        Console.WriteLine($"Camera: {Camera}");
        Console.WriteLine($"Screen Size: {ScreenSize}");
    }
}