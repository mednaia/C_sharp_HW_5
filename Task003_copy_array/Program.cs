// Написать программу копирования массива
int[] array = {9,8,7,6,5,4,3,2,1};
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");

void CopyArray(int[] array)
{
    int[] ar = new int[array.Length];
    for(int i=0;i<array.Length;i++)
    {
        int index=i;
        ar[index] = array[i];
        Console.Write($"{ar[index]} ");
    }
}
Console.WriteLine();
Console.WriteLine("Copy of array:");
CopyArray(array);
