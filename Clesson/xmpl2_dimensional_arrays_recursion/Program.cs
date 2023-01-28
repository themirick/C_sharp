// Two-dimensional array

string[,] table = new string[2, 5];
table[1, 2] = "word";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



void PrintTable(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillTable(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];
PrintTable(matrix);

System.Console.WriteLine();
FillTable(matrix);
PrintTable(matrix);


//RECURSION

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n* Factorial(n-1);
}

System.Console.WriteLine(Factorial(5));