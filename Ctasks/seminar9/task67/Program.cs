// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SumDigitsOfNumber(int anynumber)
{
    if (anynumber < 10) return anynumber;
    
    return anynumber % 10 + SumDigitsOfNumber(anynumber / 10);
}

System.Console.WriteLine($"Summ of the digits in number is>> {SumDigitsOfNumber(1222)}");