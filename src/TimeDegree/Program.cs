using TimeDegree.Core;
using TimeDegree;

Console.WriteLine("Enter hours: ");
var minutes = int.Parse(Console.ReadLine());

Console.WriteLine("Enters minutes: ");
var hours = int.Parse(Console.ReadLine());

ICalculate r = new Time(minutes, hours);

Console.WriteLine("Degree between arrows: ");
Console.WriteLine(r.CalculateDegree());



