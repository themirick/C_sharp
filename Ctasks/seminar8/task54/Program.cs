// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrixRows(int[,] array2D)
{
    int temp;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int k = 0; k < array2D.GetLength(1); k++)
        {
            for (int j = 0; j < array2D.GetLength(1) -1 - k; j++)
            {
                if (array2D[i, j] < array2D[i, j + 1])
                {
                    temp = array2D[i, j];
                    array2D[i, j] = array2D[i, j + 1];
                    array2D[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] array2D = new int[4, 4];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();
System.Console.WriteLine("Here is your sorted matrix>> ");
System.Console.WriteLine();

SortMatrixRows(array2D);
PrintArray2D(array2D);
