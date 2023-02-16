// Написать программу масштабирования фигуры

Console.Write("Введите кол-во вершин фигуры: ");
int count = int.Parse(Console.ReadLine() ?? "");

double[] arrX = new double[count];

double[] arrY = new double[count];

Console.WriteLine("Сгенерированы координаты вершин фигуры:");

for (int i = 0; i < count; i++)
{
    if ( i < count-1)
    {
    arrX[i] = new Random().Next(11);
    arrY[i] = new Random().Next(11);
    Console.Write($"({arrX[i]};{arrY[i]}), ");
    }
    else  Console.WriteLine($"({arrX[i]};{arrY[i]})");
}

Console.Write("Введите коэффициент масштабирования k: ");
double k = double.Parse(Console.ReadLine() ?? "");       

Console.WriteLine($"Координаты вершин фигуры с масштабированием в k (равное {k}) раз:");

for (int i = 0; i < count; i++)
{
   if (i < count - 1)
   {
     arrX[i] = arrX[i] * k;
    arrY[i] = arrY[i] * k;
    Console.Write($"({arrX[i]};{arrY[i]}), ");
   }
   else Console.Write($"({arrX[i]};{arrY[i]})");
}

