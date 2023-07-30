/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] array = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array);
int[,] sortArray = SortRowsMatrix(array);
Console.WriteLine();
Console.WriteLine("Отсортрованный массив:");
PrintMatrix(sortArray);


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

int[,] SortRowsMatrix(int[,] matrix)
{
    //int[,] sortMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int[,] sortMatrix = matrix;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        //int max = matrix[i,0];
        for(int t = 0; t < matrix.GetLength(1) - 1; t++)
        {
            int max = matrix[i,0];
            for(int j = 0; j < (matrix.GetLength(1) - 1) - t; j++)
            {
                if(max < sortMatrix[i, j + 1]) 
                {
                    sortMatrix[i,j] = sortMatrix[i, j + 1];
                    sortMatrix[i, j + 1] = max;
                }
                else max = sortMatrix[i, j + 1];
            }
        }
    }
    return sortMatrix;
}