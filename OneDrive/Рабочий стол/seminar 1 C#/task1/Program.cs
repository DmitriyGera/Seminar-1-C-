// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение А => ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите число B => ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

int value = numberA * numberA;
if (numberB == value) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}