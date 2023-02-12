// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int [] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int[] CopyArray(int[] array)
{
    int len = array.Length;
    int[] mirrorArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        mirrorArray[i] = array[i];   // в задании сказано что нужно делать с помощью поэлементного копирования.
    }
    return mirrorArray;
}

PrintArray(CopyArray(array));


// also would work this method >> 
// Array.Copy(array, mirrorArray);