int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int x1 = Prompt("Введите х первой точки: ");
int y1 = Prompt("Введите y первой точки: ");
int x2 = Prompt("Введите х второй точки: ");
int y2 = Prompt("Введите y второй точки: ");
double x3 = x1 - x2;
double y3 = y1 - y2;

double d = Math.Sqrt(Math.Pow(x3, 2)+ Math.Pow(y3, 2));
Console.WriteLine(d);