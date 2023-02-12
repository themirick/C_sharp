// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FibonacciNum(int lastNumber)
{
    int[] result = new int[lastNumber];
    result[0] = 0;
    result[1] = 1;

    for (int i = 2; i <= lastNumber - 1; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

PrintArray(FibonacciNum(GetNumber("Inter last number to calculate Fibonacci>> ")));