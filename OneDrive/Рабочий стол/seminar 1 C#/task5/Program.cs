// See https://aka.ms/new-console-template for more information
Console.Write("Введите число а => ");
string inputNumber = Console.ReadLine();
int numberA = int.Parse(inputNumber);

int x = numberA + 9;
Console.WriteLine($"Функция x = f(a): {x} ");
