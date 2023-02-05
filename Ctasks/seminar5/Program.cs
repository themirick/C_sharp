// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        newArray[i] = new Random().Next(100, 999);
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

int CountEvenNumInArray(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
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
System.Console.WriteLine(CountEvenNumInArray(array));
