// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string ConvertIntToBinary(int someNumber)
{
    string result = String.Empty;
    while (someNumber > 0)
    {
        result = result + $" {someNumber % 2}";
        someNumber /= 2;
    }

    string reverse = String.Empty;

    for (int i = 1; i < result.Length; i++)
    {
        reverse = reverse + $"{result[result.Length - i]}";
    }

    return reverse;
}

System.Console.WriteLine(ConvertIntToBinary(GetNumber("Input any number to convert to binary>> ")));
