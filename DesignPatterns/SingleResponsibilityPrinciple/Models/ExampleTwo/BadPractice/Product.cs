using System.Net.Mail;

namespace SingleResponsibilityPrinciple.Models.ExampleTwo.BadPractice;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public void SaveProduct(Product product)
    {
        if (product == null)
            throw new NullReferenceException();
        
        // Code for saving the product to the database and declaring whole process here
        SqlOperations connection = new SqlOperations();
        connection.Connect();
        connection.Add<Product>(product);
        
        // Code for sending mail
        SmtpClient client = new();
        client.Send(new MailMessage());

        // This method has three responsibility
    }
}

/// <summary>
/// This class created to enrich the example
/// </summary>
internal class SqlOperations
{
    public void Connect()
    {
        //Database Connection
    }
    
    public void Add<T>(T dbObject)
    {
        //Database Add
    }
}