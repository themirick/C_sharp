// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;

    else if (numberM != 0 && numberN == 0)
        return AckermannFunction(numberM - 1, 1);


    else
        return AckermannFunction(numberM - 1, 
                AckermannFunction(numberM, numberN - 1));

    return AckermannFunction(numberM, numberN);
}


Console.WriteLine(AckermannFunction(0, 0)); // 1

Console.WriteLine(AckermannFunction(1, 2)); // 4

Console.WriteLine(AckermannFunction(2, 3)); // 9

Console.WriteLine(AckermannFunction(3, 2)); // 29

// Console.WriteLine(AckermannFunction(4, 5)); // Stack Overflow !