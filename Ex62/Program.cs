/* Задача 62 *** Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Main();

void Main()
{
    int arraySize = 7;
    int[,] array = new int[arraySize, arraySize];
    SpiralFillArray(array, arraySize);
    PrintArray(array, arraySize);
}

void SpiralFillArray(int[,] userArray, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        userArray[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        value++;
    }
}

void PrintArray(int[,] printedArray, int sizeOfArray)
{
    Console.WriteLine($"Массив, имеющий размер {sizeOfArray} x {sizeOfArray}, заполнен по спирали.");
    Console.WriteLine();
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            if (printedArray[i, j] < 10)
            {
                Console.Write("0" + printedArray[i, j]);
                Console.Write(" ");
            }
            else Console.Write(printedArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
