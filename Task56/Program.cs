/* Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка */

int[,] array = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array);
int indeMinSum = NumberRows(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {indeMinSum} строка.");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}

int NumberRows(int[,] matrix)
{
    int[] minElemSumRows = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            minElemSumRows[i] = minElemSumRows[i] + matrix[i,j];

        }
    }
    int indexMinSumRows = 0;
    for(int t = 0; t < minElemSumRows.Length - 1; t++)
    {
        if(minElemSumRows[t] > minElemSumRows[t + 1]) indexMinSumRows = t + 1;
    }
    return indexMinSumRows + 1;
}