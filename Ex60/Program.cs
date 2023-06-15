/* Задача 60. ***...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Main();

void Main()
{
    int[,,] array3D = new int[6, 5, 2];
    CreateArray(array3D);
    PrintArray(array3D);
}

void PrintArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] userArray3D)
{
    int[] temp = new int[userArray3D.Length];
    int number;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < userArray3D.GetLength(0); x++)
    {
        for (int y = 0; y < userArray3D.GetLength(1); y++)
        {
            for (int z = 0; z < userArray3D.GetLength(2); z++)
            {
                userArray3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}