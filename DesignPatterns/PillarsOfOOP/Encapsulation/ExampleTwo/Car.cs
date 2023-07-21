namespace Encapsulation.ExampleTwo;

public class Car
{
    private string _make;
    private string _model;
    private int _year;
    private bool _isEngineStarted;

    #region PROPERTIES

    public string Make
    {
        get => _make;
        set => _make = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public bool IsEngineStarted
    {
        get => _isEngineStarted;
        set => _isEngineStarted = value;
    }

    #endregion

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        IsEngineStarted = false;
    }
    
    // Public method to start the car's engine. While starting engine user doesn't know processes
    // All the logic can be applied privately only the part that user should know can be
    // given as public methods.
    // For example the button in the car when you press you only expect that engine to start
    // and get ready to user drive almost all the processes are hidden.
    public void StartEngine()
    {
        if (!IsEngineStarted)
        {
            IsEngineStarted = true;
            Console.WriteLine($"Engine of {Make} {Model} started.");
        }
        else
            Console.WriteLine("Engine is already running.");
    }
    
    public void StopEngine()
    {
        if (IsEngineStarted)
        {
            IsEngineStarted = false;
            Console.WriteLine($"Engine of {Make} {Model} stopped.");
        }
        else
            Console.WriteLine("Engine is already off.");
    }
    
    // here we can filter information and display only the information that we want to display
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Engine Status: {(IsEngineStarted ? "Running" : "Off")}");
    }
}