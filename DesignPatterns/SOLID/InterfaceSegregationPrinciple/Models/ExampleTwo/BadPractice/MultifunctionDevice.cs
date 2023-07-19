using InterfaceSegregationPrinciple.Models.ExampleTwo.BadPractice.Interface;

namespace InterfaceSegregationPrinciple.Models.ExampleTwo.BadPractice;

public class MultifunctionDevice : IMultifunctionDevice
{
    // for this class IMultifunctionDevice interface is suitable because this machine can 
    // do both scanning and printing

    public void Print(string document) => Console.WriteLine($"Printing: {document}");
    
    public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
}