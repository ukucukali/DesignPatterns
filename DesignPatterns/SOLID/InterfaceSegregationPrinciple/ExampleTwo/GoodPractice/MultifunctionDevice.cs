using InterfaceSegregationPrinciple.ExampleTwo.GoodPractice.Interface;

namespace InterfaceSegregationPrinciple.ExampleTwo.GoodPractice;

public class MultifunctionDevice : IScanner, IPrinter
{
    // for this class both IScanner and IPrinter interfaces can be implemented because this machine can 
    // do both scanning and printing

    public void Print(string document) => Console.WriteLine($"Printing: {document}");
    
    public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
}