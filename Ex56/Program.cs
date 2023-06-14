/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Main();

void Main()
{
    int numM = Prompt("Введите количество строк массива: ");
    int numN = Prompt("Введите количество столбцов массива: ");
    int[,] array = GetArray(numM, numN, 1, 10);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    int minSumArrayRow = FindMinSumInRows(array);
    Console.WriteLine($"{minSumArrayRow}-я строка имеет наименьшую сумму значений элементов.");
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

int FindMinSumInRows(int[,] sortingArray)
{
    int rowMin = 0;
    int minSum = 0;
    for (int i = 0; i < sortingArray.GetLength(1); i++)
    {
        minSum += sortingArray[0, i];
    }
    for (int i = 0; i < sortingArray.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < sortingArray.GetLength(1); j++)
        {
            sumRow += sortingArray[i, j];
        }
        if (minSum > sumRow)
        {
            minSum = sumRow;
            rowMin = i;
        }
    }
    return rowMin + 1;
}