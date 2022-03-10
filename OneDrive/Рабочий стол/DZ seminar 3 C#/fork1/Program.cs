int num = 3;            
int min = -5;               
int max = 6;                

int[] PointCoords(int num)                  
{
    int[] value = new int[num];
    for (int i = 0; i < num; i++)
    {
        value[i] = new Random().Next(min, max);
    }
    return value;
}

void Print(int[] array)
{
    Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double d(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] inputA = PointCoords(num);
int[] inputB = PointCoords(num);

Console.Write($"Координаты точки А: ");
Print(inputA);
Console.Write($"Координаты точки B: ");
Print(inputB);

Console.WriteLine($"Расстояние между точками А и В: {d(inputA, inputB)}");
