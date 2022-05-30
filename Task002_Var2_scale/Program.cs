// Написать программу масштабирования фигуры
/*Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

Console.WriteLine("Enter a height of rectangle");
int y = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter a width of rectangle");
int x = int.Parse(Console.ReadLine()??"0");
for (int i=0;i<y;i++)
{
    for (int j=0;j<x;j++)
    {
       Console.Write("+");
    }
    Console.WriteLine();
}
Console.WriteLine("Input the value of scale factor:");
double scale = double.Parse(Console.ReadLine()??"0");
if(scale>0)
{
    for (int i=0;i<y*scale;i++)
    {
        for (int j=0;j<x*scale;j++)
        {
            Console.Write("+");
        }
        Console.WriteLine();
    }
}
else
{
    for (int i=0;i<y/(scale*-1);i++)
    {
        for (int j=0;j<x/(scale*-1);j++)
        {
            Console.Write("+");
        }
        Console.WriteLine();
    }
}