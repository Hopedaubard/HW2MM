/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Main();

void Main()
{
    int[,] arrayFirst = GetArray(2, 2, 1, 10);
    int[,] arraySecond = GetArray(2, 2, 1, 10);
    PrintArray(arrayFirst);
    PrintArray(arraySecond);
    int[,] arraysProd = GetProdArrays(arrayFirst, arraySecond);
    PrintArray(arraysProd);
}

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] arrayRand = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arrayRand[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arrayRand;
}

void PrintArray(int[,] userArray)
{
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            Console.Write($"{userArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetProdArrays(int[,] array1, int[,] array2)
{
    int[,] prodArrays = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                prodArrays[i, j] += array1[i, k] * array2[k, j];
                //Console.WriteLine(prodArrays[i, j]);
            }
        }
    }
    return prodArrays;
}