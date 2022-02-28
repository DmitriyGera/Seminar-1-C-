// See https://aka.ms/new-console-template for more information
Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);

int A = 0 - N;
Console.Write(A+" ");
while (A < N)
{
    A = A + 1;
    Console.Write(A+" ");
}