// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray2D(int[,,] array3D)
{
    int xRay = array3D.GetLength(0);
    int yRay = array3D.GetLength(1);
    int zRay = array3D.GetLength(2);

    int counter = 10;

    for (int i = 0; i < xRay; i++)
    {
        for (int j = 0; j < yRay; j++)
        {
            for (int k = 0; k < zRay; k++)
            {
                array3D[i, j, k] = counter++;
            }
        }
    }
}

void PrintArrayWithIndex3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                System.Console.Write($"{array3D[i, j, k]}({i},{j},{k}) |");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] array3D = new int[2, 2, 2];

FillArray2D(array3D);
PrintArrayWithIndex3D(array3D);