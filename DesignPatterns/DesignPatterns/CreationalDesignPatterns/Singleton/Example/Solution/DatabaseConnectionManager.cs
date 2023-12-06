namespace Singleton.Example.Solution;

public class DatabaseConnectionManager
{
    private static DatabaseConnectionManager _instance;
    private static readonly object _lockObject = new();
    
    private string _connectionString;

    public DatabaseConnectionManager(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public static DatabaseConnectionManager Instance
    {
        get
        {
            // Double-check locking for thread safety
            if (_instance == null)
                lock (_lockObject)
                    if (_instance == null)
                        // Initialize the instance with a default connection string
                        _instance = new DatabaseConnectionManager("default_connection_string");
            
            return _instance;
        }
    }

    public void Connect()
    {
        Console.WriteLine($"Connected to the database using {_connectionString}");
    }

 
}