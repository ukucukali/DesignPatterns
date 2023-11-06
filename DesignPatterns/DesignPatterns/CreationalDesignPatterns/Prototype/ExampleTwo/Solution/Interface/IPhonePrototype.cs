namespace Prototype.ExampleTwo.Solution.Interface;

public interface IPhonePrototype
{
    IPhonePrototype Clone();

    void ConfigureOS(string os);

    void SetStorage(int storage);

    void SetCamera(string camera);

    void SetScreenSize(double size);

    void DisplayDetails();
}