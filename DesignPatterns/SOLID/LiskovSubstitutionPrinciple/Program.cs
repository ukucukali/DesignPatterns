


using System.Net.Http.Json;
using LiskovSubstitutionPrinciple.Models.ExampleTwo.BadPractice;

Console.WriteLine("Please Check examples in models folder \n");


// bad practice apple can be overwritten by banana class and banana class depends on apple class
// which can be over written by mistakenly 
Console.WriteLine("Bad Practice\n");

var apple = new Banana();
Console.WriteLine(apple.GetName());

var banana = new Banana();
Console.WriteLine(banana.GetName());


// good practice apple and banana will keep their self unchanged and they will not depend on each other
Console.WriteLine("Good Practice\n");

 var apple2 = new LiskovSubstitutionPrinciple.Models.ExampleTwo.GoodPractice.Apple();
Console.WriteLine(apple2.GetName());

 var banana2 = new LiskovSubstitutionPrinciple.Models.ExampleTwo.GoodPractice.Banana();
Console.WriteLine(banana2.GetName());




