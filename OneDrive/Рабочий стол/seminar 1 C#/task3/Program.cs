// See https://aka.ms/new-console-template for more information
Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

if (number == 1) Console.WriteLine("Понедельник"); else
if (number == 2) Console.WriteLine("Вторник");else
if (number == 3) Console.WriteLine("Среда");else
if (number == 4) Console.WriteLine("Четверг");else
if (number == 5) Console.WriteLine("Пятница");else
if (number == 6) Console.WriteLine("Суббота");else
if (number == 7) Console.WriteLine("Воскресенье");else
{
    Console.WriteLine("В неделе 7 дней!!! ");
}
