// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ToGrade(int numA, int numB)
{
    int result = 1;

    for (int i = 1; i <= numB; i++)
        result *= numA;
    return result;
}

int numA = GetNumber("Input your number>> ");
int numB = GetNumber("Input needed grade of number>> ");

System.Console.WriteLine(ToGrade(numA, numB));