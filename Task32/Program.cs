/* Задача 32: Напишите программу замена элементов
 массива: положительные элементы замените на
соответствующие отрицательные, и наоборот. */

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
InverseArray(array);
Console.WriteLine();
PrintArray(array);

void InverseArray(int[] arr )
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}