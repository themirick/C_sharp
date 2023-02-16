// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
// [nXn]
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

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
            System.Console.Write($"{array2D[i, j],-2}");
        }
        System.Console.WriteLine();
    }
}

void ReplaceRowsColumns(int[,] array2D)
{
    if (array2D.GetLength(0) != array2D.GetLength(1))
    {
        System.Console.WriteLine("Sides of matrix must be equal!");
        return;
    }
    else
    {
        for (int i = 1; i < array2D.GetLength(1); i++)
        {
            int tepm = array2D[0, i];
            array2D[0, i] = array2D[i, 0];
            array2D[i, 0] = tepm;
        }
    }
}


int[,] array2D = new int[4, 4];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();
System.Console.WriteLine();

ReplaceRowsColumns(array2D);
PrintArray2D(array2D);
