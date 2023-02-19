// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// The project is under development yet
// Проект всё ещё на стадии разработки



void FillMatrixSpirally(int[,] matrix)
{
    int raw = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= raw * column)
    {
        matrix[i, j] = temp;
        temp++;

        if (i <= j + 1 && i + j < column - 1)
            j++;
        else if (i < j && i + j >= raw - 1)
            i++;
        else if (i >= j && i + j > column - 1)
            j--;
        else
            i--;
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j],-3}|");
        }
        System.Console.WriteLine();
    }
}



int[,] array2D = new int[4, 4];

FillMatrixSpirally(array2D);
PrintArray2D(array2D);
