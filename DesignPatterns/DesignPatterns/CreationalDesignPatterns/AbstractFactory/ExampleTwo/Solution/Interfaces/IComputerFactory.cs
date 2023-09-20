namespace AbstractFactory.ExampleTwo.Solution.Interfaces;

public interface IComputerFactory
{
    IProcessor CreateProcessor();
    
    IStorage CreateStorage();
}