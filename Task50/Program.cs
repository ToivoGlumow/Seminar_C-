/* Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет */

int[,] array = CreateMatrixRndInt(4, 5, 0, 9);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine("Введите индексы элемента массива(MxN)");
Console.Write("M: ");
int fistIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("N: ");
int secondIndex = Convert.ToInt32(Console.ReadLine());

if (SearchElement(array, fistIndex, secondIndex)) 
{
    Console.WriteLine($"Элемент с индексами {fistIndex}, {secondIndex} -> {array[fistIndex,secondIndex]}");
}
else Console.WriteLine($"Элемента с индексами {fistIndex}, {secondIndex} -> не существует");

bool SearchElement(int[,] matrix, int x, int y)
{
    if ((x < matrix.GetLength(0)) && (x >= 0) && (y < matrix.GetLength(1)) && (y >= 0)) return true;
    else return false;
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