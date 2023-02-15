// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j], -2}");
        }
        System.Console.WriteLine();
    }
}

void ColumnsAverage(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            result += array2D[j,i];
            System.Console.Write($"{array2D[j,i]}, ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Average of {i+1}th column>> {result/array2D.GetLength(0):F1}");
        System.Console.WriteLine();
    }
}


int[,] array2D = new int[3, 4];

FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
ColumnsAverage(array2D);