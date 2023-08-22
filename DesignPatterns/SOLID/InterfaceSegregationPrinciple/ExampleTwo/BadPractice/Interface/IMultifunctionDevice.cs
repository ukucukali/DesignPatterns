namespace InterfaceSegregationPrinciple.ExampleTwo.BadPractice.Interface;

public interface IMultifunctionDevice
{
    void Print(string document);
    
    void Scan(string document);
}