namespace Polymorphism.ExampleOne;

public  class Employee
{
    public string Name { get; set; }
    
    public int WorkHours { get; set; }

    public virtual decimal CalculateSalary()
    {
        // Default implementation for base class, overridden in derived classes
        return 0; 
    }
}