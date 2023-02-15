// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
            System.Console.Write($"{array2D[i, j], -5}");
        }
        System.Console.WriteLine();
    }
}

void SquaringMethod(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array2D[i,j] = array2D[i,j] * array2D[i,j];
            }
        }
    }
}

int[,] array2D = new int[6, 6];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();
System.Console.WriteLine("Here is new array!");
System.Console.WriteLine();

SquaringMethod(array2D);
PrintArray2D(array2D);