// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// ❗ Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.


int GetNumber(string massage)
{
    System.Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckTriangleSides(int sideA, int sideB, int sideC)
{
    int sum = sideA + sideB + sideC;
    int[] triangle = new int[] {sideA, sideB, sideC};
    for (int i = 0; i < triangle.Length; i++)
    {
        if (triangle[i] > sum - triangle[i])
        {
            System.Console.WriteLine("Your triangle sides are not fit the formula: AB < AC + CB");
            return;
        }
    }
    System.Console.WriteLine("Your triangle is correct!");
}

int sideA = GetNumber("Input sida A of triangle>> ");
int sideB = GetNumber("Input sida B of triangle>> ");
int sideC = GetNumber("Input sida C of triangle>> ");

CheckTriangleSides(sideA, sideB, sideC);