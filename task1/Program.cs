// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

Console.WriteLine("Нам даны две прямые, заданные уравнениями:");
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");
double x = 1;
double y = 1;

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Нет решений, т. к. возникает деление на 0, следовательно прямые параллельны");
else
{
y = (k1 * b2 - k2 * b1) / (k1 - k2);
x = (b1 - y) / k1;

Console.WriteLine($"Точка пересечения указанных прямых имеет координаты ({x}; {y})");
}