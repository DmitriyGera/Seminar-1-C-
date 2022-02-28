// See https://aka.ms/new-console-template for more information
Console.Write("Введите число =>");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);

int result = value * value;
Console.WriteLine(result);