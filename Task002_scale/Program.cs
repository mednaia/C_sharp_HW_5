// Написать программу масштабирования фигуры
/*Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/


void PrintImage(int[,] image)
{
    for(int i = 0; i < image.GetLength(0); i++)
    {
        for(int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine(); 
    }
}

Console.Write("Input the number of strings of array: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns of array: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] array2D = new int[x,y];
// int length = array2D.Length;
// int index = 0;


for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array2D[i, j] = 0;
    }
}

int pointMinX = 0; //Convert.ToInt32(Console.ReadLine());
int pointMaxX = 4;
int pointMinY = 0; //Convert.ToInt32(Console.ReadLine());
int pointMaxY = 4;


for (int i = pointMinX; i < pointMaxX; i++)
{
    for (int j = pointMinY; j < pointMaxY; j++)
    {
        array2D[i, j] = 1;
    }
}


// for (int i = 0; i < x; i++)
// {
//     for (int j = 0; j < y; j++)
//     {
//         Console.Write(array2D[i, j]);
//     }
//     Console.WriteLine();
// }

PrintImage(array2D);

Console.Write("Input the value of scale factor: ");
int ext = Convert.ToInt32(Console.ReadLine());
if(ext<0) 
{
    pointMaxX=pointMaxX/(ext*-1);
    pointMaxY=pointMaxY/(ext*-1);
}
else
{
    pointMaxX=pointMaxX*ext;
    pointMaxY=pointMaxY*ext;
}


for (int i = pointMinX; i<x; i++)
{
    for (int j = pointMinX; j<y; j++)
    {
        array2D[i, j] = 0;
    }
}

for (int i = pointMinX; i < pointMaxX; i++)
{
    for (int j = pointMinY; j < pointMaxY; j++)
    {
        array2D[i, j] = 1;
    }
}


// for (int i = 0; i < x; i++)
// {
//     for (int j = 0; j < y; j++)
//     {
//         Console.Write(array2D[i, j]);
//     }
//     Console.WriteLine();
// }

PrintImage(array2D);


