using Prototype.ExampleOne.Problem;
using Prototype.ExampleOne.Solution.Interfaces;
using Prototype.ExampleTwo.Solution.Interface;
using Solution = Prototype.ExampleOne.Solution;
using SmartPhone = Prototype.ExampleTwo.Solution.SmartPhone;
using Problem = Prototype.ExampleTwo.Problem;

/*
  STRUCTURE
 * Create prototype abstract/interface class with clone method.
 * Create constructor that accepts an object as argument, and all the values of the object must be copied.
 * All the copied values should be passed into a new instance.
 */

#region Example One - Document

#region Problem

// Coping documents manually can be error-prone and inefficient.  

Document originalDoc = new Document("Original document", "Original content", "Formatting for original document");

Document clonedDocument = originalDoc.Clone();

clonedDocument.Title = "Cloned document";
clonedDocument.Content = "Cloned content";

Console.WriteLine("-Original Document-");
originalDoc.Display();
Console.WriteLine("\n-Cloned Document-");
clonedDocument.Display();

#endregion

Console.WriteLine("\n---------\n\n-Original Document-");

#region Solution

IDocumentPrototype originalDocument = new Solution.Document("Original document", 
    "Original content", "Formatting for original document");

var clonedDoc = originalDocument.Clone();

clonedDoc.SetTitle("Cloned document");
clonedDoc.SetContent("Cloned content");

originalDoc.Display();
Console.WriteLine("\n-Cloned Document-");
clonedDocument.Display();

#endregion

#endregion

Console.WriteLine("\n---------\n\n-Original Phone Details-");

#region Example Two - SmartPhone

#region Problem

var smartPhone = new Problem.SmartPhone("Android", 128, "12MP", 6.7);

var smartPhoneCopy = new Problem.SmartPhone(smartPhone.OS, smartPhone.Storage, smartPhone.Camera, smartPhone.ScreenSize);
smartPhoneCopy.Storage = 256;
smartPhoneCopy.Camera = "48MP";
smartPhoneCopy.ScreenSize = 6.1;

smartPhone.DisplayDetails();
Console.WriteLine("\n-Cloned Phone-");
smartPhoneCopy.DisplayDetails();

#endregion

Console.WriteLine("\n---------\n\n-Original Phone Details-");

#region Solution

IPhonePrototype newSmartPhone = new SmartPhone();
newSmartPhone.ConfigureOS("IOS");
newSmartPhone.SetStorage(128);
newSmartPhone.SetCamera("24MP");
newSmartPhone.SetScreenSize(6.1);

IPhonePrototype newSmartPhoneCopy = newSmartPhone.Clone();
newSmartPhoneCopy.SetStorage(256);
newSmartPhoneCopy.SetCamera("48MP");
newSmartPhoneCopy.SetScreenSize(6.7);

newSmartPhone.DisplayDetails();
Console.WriteLine("\n-Cloned Phone Details-");
newSmartPhoneCopy.DisplayDetails();

#endregion

#endregion