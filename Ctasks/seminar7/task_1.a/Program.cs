// Дан двумерный массив. Поменять местами:
// а) элементы, расположенные в правом верхнем и левом нижнем углах;


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

void ReplaceCells(int[,] array2D)
{
    int rawLength = array2D.GetLength(0);
    int columnLength = array2D.GetLength(1);
    
    int temp = array2D[rawLength - 1, 0];
    array2D[rawLength-1, 0] = array2D[0, columnLength-1];
    array2D[0, columnLength-1] = temp;
}

int[,] array2D = new int[3, 4];

FillArray2D(array2D);
PrintArray2D(array2D);

System.Console.WriteLine();
System.Console.WriteLine("Here is your new array!!!");
System.Console.WriteLine();

ReplaceCells(array2D);
PrintArray2D(array2D);