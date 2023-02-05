// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] MakeArray(int arraySize)
{
    int[] newArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        newArray[i] = new Random().Next(1, 100);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int MaxInArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int MinInArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int arraySize = GetNumber("Inter needed size of array>> ");
if (arraySize < 0)
{
    System.Console.WriteLine("Restart the programm and enter anoter number");
    return;
}

int[] array = MakeArray(arraySize);
PrintArray(array);

System.Console.WriteLine();

int difference = MaxInArray(array) - MinInArray(array);
System.Console.WriteLine($"Difference of min and max numbers in array>> {difference}");

// also would work this method too
// int diff = array.Max() - array.Min();