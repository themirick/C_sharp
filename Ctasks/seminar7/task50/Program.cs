// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

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

void FindElementFromPosition(int[,] array2D, int elementRawPosition, int elementColumnPosition)
{
    if(elementRawPosition > array2D.GetLength(0) 
        && elementColumnPosition > array2D.GetLength(1))
    {
        System.Console.WriteLine("There is no element with this position");
        return;
    }
    else
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                if (elementRawPosition-1 == i 
                    && elementColumnPosition-1 == j)
                    System.Console.WriteLine($"The desired number is>> {array2D[i,j]}");

            }
        }
    }
}

int[,] array2D = new int[3, 4];

FillArray2D(array2D);
PrintArray2D(array2D);
FindElementFromPosition(array2D, 2,2);