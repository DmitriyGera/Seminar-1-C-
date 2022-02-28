double a, b;
Console.Write("Введите число A = "); 
string gotcha = Console.ReadLine();
a = double.Parse(gotcha);
Console.Write("Введите число B = "); 
gotcha = Console.ReadLine();
b = double.Parse(gotcha);
const string lt = "<", gt = ">";
if (a < b) 
gotcha = lt; 
else 
gotcha = gt;
Console.WriteLine($" { a } { gotcha } { b } ");

