namespace Singleton.Example.Problem;

public class DatabaseConnectionManager
{
    private string _connectionString;

    public DatabaseConnectionManager(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public void Connect()
    {
        Console.WriteLine($"Connected to the database using {_connectionString}");
    }
}