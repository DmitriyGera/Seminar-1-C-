Console.Write("Введите целое число: ");
string number = Console.ReadLine();
int length = number.Length; 
bool n()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}
if (n()) 
Console.WriteLine($"Введенное число - {number} - является палиндромом");
else Console.WriteLine($"Введенное число {number} не является палиндромом");
