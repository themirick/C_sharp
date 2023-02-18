// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.



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

int[] MatrixToArray(int[,] array2D)
{
    int raws = array2D.GetLength(0);
    int columns = array2D.GetLength(1);

    int[] exMatrix = new int[raws * columns];

    for (int i = 0; i < exMatrix.Length; i++)
    {
        exMatrix[i] = array2D[i / columns, i % columns];
    }
    return exMatrix;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

void ArrayElementCounter(int[] array)
{
    int[] tempArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        int counter = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (tempArray.Contains(array[i]) == false && array[i] == array[j])
            {
                counter++;
            }
            else System.Console.WriteLine($"The number {array[i]} occurs {counter} times");
        }
        tempArray[i] = array[i];
    }
}

int[,] array2D = new int[4, 4];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();

int[] exMatrix = MatrixToArray(array2D);
PrintArray(exMatrix);
ArrayElementCounter(exMatrix);