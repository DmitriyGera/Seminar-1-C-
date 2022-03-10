int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int N = Prompt("Введите число: ");

int A = 1;
Console.Write(A + " ");
while (A <= N)
{
    A = A + 1;
    Console.Write(A * A + " ");
}