namespace Builder.ExampleOne.GoodPractice;

public class ComputerBuilder
{
    private Computer _computer = new();

    public ComputerBuilder SetCpu(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRam(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }

    public ComputerBuilder SetGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
        return this;
    }
    
    public Computer Build()
    {
        return _computer;
    }
}