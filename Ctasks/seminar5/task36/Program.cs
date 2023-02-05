// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        newArray[i] = new Random().Next(-10, 10);
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

int SumOddPositionArray(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        counter += array[i];
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
System.Console.WriteLine(SumOddPositionArray(array));