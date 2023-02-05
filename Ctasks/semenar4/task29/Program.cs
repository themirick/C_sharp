// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] MakeArray(int arraySize)
{
    int [] newArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        newArray[i] = new Random().Next(1, 10);
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

int arraySize = GetNumber("Inter needed size of array>> ");
if (arraySize < 0)
{
    System.Console.WriteLine("Restart the programm and enter anoter number");
    return;
}
PrintArray(MakeArray(arraySize));
