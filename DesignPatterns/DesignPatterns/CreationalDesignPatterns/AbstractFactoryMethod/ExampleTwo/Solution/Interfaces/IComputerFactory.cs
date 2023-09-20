namespace AbstractFactoryMethod.ExampleTwo.Solution.Interfaces;

public interface IComputerFactory
{
    IProcessor CreateProcessor();
    
    IStorage CreateStorage();
}