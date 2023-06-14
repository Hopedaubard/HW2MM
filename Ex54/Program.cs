/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Main();

void Main()
{
    int numM = Prompt("Введите количество строк массива: ");
    int numN = Prompt("Введите количество столбцов массива: ");
    int[,] array = GetArray(numM, numN, 1, 10);
    Console.WriteLine();
    PrintArray(array);
    int[,] arraySort = SortArrayMaxToMin(array);
    Console.WriteLine();
    PrintArray(arraySort);
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
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

int[,] SortArrayMaxToMin(int[,] sortingArray)
{
    int temp = 0;
    for (int i = 0; i < sortingArray.GetLength(0); i++)
    {
        for (int j = 1; j < sortingArray.GetLength(1); j++)
        {
            for (int k = 1; k < sortingArray.GetLength(1); k++)
            {
                temp = sortingArray[i, k - 1];
                if (sortingArray[i, k - 1] < sortingArray[i, k] /*&& j < sortingArray.GetLength(1)*/)
                {
                    sortingArray[i, k - 1] = sortingArray[i, k];
                    sortingArray[i, k] = temp;
                }
            }
        }
    }
    return sortingArray;
}