// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int MachNumber(int anyNumber)
{
    int result = 0;
    while (anyNumber > 0)
    {
        result += anyNumber % 10;
        anyNumber /= 10;
    }
    return result;
}

int number = GetNumber("Inter any number to get sum>> ");
System.Console.WriteLine(MachNumber(number));