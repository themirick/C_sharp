// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 5);
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

int[,] MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int rowOne = matrixOne.GetLength(0);
    int columnOne = matrixOne.GetLength(1);
    int rowTwo = matrixOne.GetLength(0);
    int columnTwo = matrixOne.GetLength(1);

    if (rowOne != columnTwo) 
        throw new Exception("Can't multiply this matrix, please read matrix multiplication rules");
    
    
    else
    {
        int[,] resultMatrix = new int[rowOne, columnTwo];

        for (int i = 0; i < rowOne; i++)
        {
            for (int j = 0; j < columnTwo; j++)
            {
                for (int k = 0; k < rowTwo; k++)
                {
                    resultMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j]; // в этом моменте нужно вперва хорошо вникнуть
                }
            }
        }
        return resultMatrix;
    }
}

int[,] matrixOne = new int[2, 2];
int[,] matrixTwo = new int[2, 2];


// Executive unit

FillArray2D(matrixOne);
PrintArray2D(matrixOne);
System.Console.WriteLine();
System.Console.WriteLine();


FillArray2D(matrixTwo);
PrintArray2D(matrixTwo);
System.Console.WriteLine();
System.Console.WriteLine();


PrintArray2D(MultiplyMatrix(matrixOne, matrixTwo));

