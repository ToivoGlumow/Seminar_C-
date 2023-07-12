/*  Напишите программу, которая задаёт
массив из 8 элементов, заполненный
псевдослучайными числами и выводит их на экран. */

int[] arrayNums = new int[8];

FillArray(arrayNums);
PrintArray(arrayNums);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arrayNums[i] = rnd.Next(100);
    }
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}, ");
     for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
