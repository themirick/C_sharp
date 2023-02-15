// б) расчета произведения двух любых элементов пятого столбца массива.
// можно задавать любую строку и любые элементы в диапозоне допустимого
// работать над исключениями нет времени


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

int MultiplyNumbersInColumn(int[,] array2D, 
                            int columnNumberToMultiply, 
                            int firstNumberToMultiply, 
                            int secondNumberToMultiply)
{
    int result = array2D[firstNumberToMultiply-1, columnNumberToMultiply-1] 
                * array2D[secondNumberToMultiply-1, columnNumberToMultiply-1];
    return result;
}


int[,] array2D = new int[3, 5];

FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
System.Console.Write("the summ is>> ");
System.Console.WriteLine(MultiplyNumbersInColumn(array2D, 5, 2, 3));
