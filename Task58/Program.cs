/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] fisrtArray = CreateMatrixRndInt(2, 2, 0, 9);
Console.WriteLine("Первая матрица:");
PrintMatrix(fisrtArray);
int[,] secondArray = CreateMatrixRndInt(2, 2, 0, 9);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondArray);

if (fisrtArray.GetLength(1) != secondArray.GetLength(0)) Console.WriteLine("Перемножать матрицы нельзя!");

int[,] resultMultArray = MultiMatrix(fisrtArray, secondArray);
Console.WriteLine("Результат умножения двух матриц:");
PrintMatrix(resultMultArray);

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


int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < multMatrix.GetLength(1); j++)
        {
           multMatrix[i, j] = 0;
           for (int t = 0; t < matrix1.GetLength(1); t++)
           {
            multMatrix[i, j] += matrix1[i, t] * matrix2[t, j];
           }
        }
    }
    return multMatrix;
}