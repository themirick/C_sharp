// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void ListNumbersRec(int currentIndex, int listLimit)
{
    if (currentIndex == listLimit + 1)
        return;

    System.Console.WriteLine(currentIndex);
    ListNumbersRec(++currentIndex, listLimit);
}

ListNumbersRec(1, 5);