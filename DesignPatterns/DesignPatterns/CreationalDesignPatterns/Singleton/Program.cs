#region DatabaseConnection

#region Problem

using Singleton.Example.Problem;

DatabaseConnectionManager manager1 = new DatabaseConnectionManager("connection_string_1");
DatabaseConnectionManager manager2 = new DatabaseConnectionManager("connection_string_2");

// Both managers are separate instances and it can create connection string confusion
manager1.Connect();
manager2.Connect();

#endregion

Console.WriteLine("\n---------\n\n- -");

#region Solution

Singleton.Example.Solution.DatabaseConnectionManager manager3 = Singleton.Example.Solution.DatabaseConnectionManager.Instance;
Singleton.Example.Solution.DatabaseConnectionManager manager4 = Singleton.Example.Solution.DatabaseConnectionManager.Instance;

// Both managers reference the same thread-safe instance
manager3.Connect();
manager4.Connect();

#endregion

#endregion






Console.WriteLine("");