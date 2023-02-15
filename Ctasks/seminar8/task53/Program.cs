// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


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

void ReplaceRows(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        int tepm = array2D[0, i];
        array2D[0,i] = array2D[array2D.GetLength(0)-1, i];
        array2D[array2D.GetLength(0)-1, i] = tepm;
    }
}


int[,] array2D = new int[3, 4];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();
System.Console.WriteLine();

ReplaceRows(array2D);
PrintArray2D(array2D);