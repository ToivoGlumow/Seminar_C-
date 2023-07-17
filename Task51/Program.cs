/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

int[,] array = CreateMatrixRndInt(4, 3, 0, 9);
PrintMatrix(array);
int sumElements = SumElementsMainDiagonals(array);
Console.Write($"Сумма элементов главной диагонали: ");
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j && i >= (array.GetLength(0) - 1)) Console.Write($"{array[i, j]} = ");
            else if(i == j) Console.Write($"{array[i, j]} + ");
        }
    }
Console.WriteLine(sumElements);


int SumElementsMainDiagonals(int[,] arr)
{
    int sum = 0;
    int size = arr.GetLength(0);
    if (size > arr.GetLength(1)) size = arr.GetLength(1);
    for(int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

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
