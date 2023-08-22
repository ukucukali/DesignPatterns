namespace InterfaceSegregationPrinciple.ExampleTwo.BadPractice;

public class Printer
{
    
    // for this class IMultifunctionDevice interface isn`t suitable because this printer only can 
    // do printing so scanning option is redundant
    
    public void Print(string document) => Console.WriteLine($"Printing: {document}");
    
    public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
}