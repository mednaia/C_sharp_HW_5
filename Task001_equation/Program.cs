// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Input the number K1 for the first equation: ");
double k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Input the number B1 for the first equation: ");
double b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Input the number K2 for the second equation: ");
double k2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Input the number B2 for the second equation: ");
double b2 = int.Parse(Console.ReadLine() ?? "0");
double x = 0;
double y = 0;
if(k1 == k2 && b1 != b2) Console.WriteLine("Two lines are parallel");
else if (k1 == k2 && b1 == b2) Console.WriteLine("Two lines match up");
else if (k1 != k2 && b1 != b2)
{
    y=(k1*b2-k1*b1)/(k1-k2)+b1;
    x=(b2-b1)/(k1-k2);
    Console.WriteLine($"Coordinates of the intersection point x={x} & y={y}");
}
