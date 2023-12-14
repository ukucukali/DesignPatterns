using Adapter.ExampleOne.Problem;
using Solution = Adapter.ExampleOne.Solution;
/*
  OBJECT ADAPTER STRUCTURE
 * Define target interface.
 * Create Adapter class which implements the target interface and wraps the legacy application object.
 * Implement methods in the target interface.
 * Inside the adapter methods, the adapter translates data formats and calls corresponding methods on the targeted application object.
 
 */

/*
  OBJECT ADAPTER STRUCTURE
 * 
 */

#region Example One - OBJECT ADAPTER STRUCTURE

#region Problem

OldSystem oldSystem = new OldSystem();
oldSystem.SpecificRequest();

// The client cannot use Legacy directly
// NewClient client = new NewClient();
// client.MakeRequest();

#endregion

#region Solution 

// Using the Object Adapter
var legacyApp = new Solution.OldSystem();
var objectAdapter = new Solution.ObjectAdapter(legacyApp);

// The client can now use the adapted interface
var client = new Solution.Client();
client.MakeRequest(objectAdapter);

#endregion

#endregion

Console.WriteLine("");