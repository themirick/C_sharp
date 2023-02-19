// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int start, int limit)
{
    if (start == limit) return start;                                    // Если M=N

    else if (start < limit) return limit + SumNumbers(start, limit - 1); // Если M<N
    
    else return limit + SumNumbers(start, limit + 1);                    // Если M>N
}

System.Console.WriteLine($"Summ of the interval>> {SumNumbers(1, 15)}");