// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
            System.Console.Write($"{array2D[i, j],3}");
        }
        System.Console.WriteLine();
    }
}

int[] SumMatrixRows(int[,] array2D)
{
    int[] rowSums = new int[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            result += array2D[i, j];
        }
        rowSums[i] = result;
    }
    return rowSums;
}

void FindMinRow(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array.Min())
            System.Console.WriteLine($"The smallest row is the {i+1}th = {array[i]}");
    }
}

int[,] array2D = new int[4, 4];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();

FindMinRow(SumMatrixRows(array2D));