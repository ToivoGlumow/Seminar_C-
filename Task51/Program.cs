// See https://aka.ms/new-console-template for more information

int[,] array = CreateMatrixRndInt(3, 4, 0, 9);
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
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) sum = sum + arr[i, j];
        }
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
