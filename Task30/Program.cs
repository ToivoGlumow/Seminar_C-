/* Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int[] arrayNums = new int[8];

FillArray(arrayNums);
PrintArray(arrayNums);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        arrayNums[i] = new Random().Next(2);
    }
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
