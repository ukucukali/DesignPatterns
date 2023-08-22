using InterfaceSegregationPrinciple.ExampleTwo.BadPractice.Interface;

namespace InterfaceSegregationPrinciple.ExampleTwo.BadPractice;

public class Scanner: IMultifunctionDevice
{
    
    // for this class IMultifunctionDevice interface isn`t suitable because this printer only can 
    // do scanning so printing option is redundant
    
    public void Print(string document) => Console.WriteLine($"Printing: {document}");
    
    public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
}