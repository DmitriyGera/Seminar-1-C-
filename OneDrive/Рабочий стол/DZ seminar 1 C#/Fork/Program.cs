double a, b;
Console.Write("Введите число A = "); 
string input = Console.ReadLine();
a = double.Parse(input);
Console.Write("Введите число B = "); 
input = Console.ReadLine();
b = double.Parse(input);
const string lt = "<", gt = ">";
if (a < b) 
input = lt; 
else 
input = gt;
Console.WriteLine($" { a } { input } { b } ");
