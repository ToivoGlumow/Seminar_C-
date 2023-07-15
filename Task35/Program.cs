// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] array = CreateArrayRndInt(12, 0, 123);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Введите границы интервала для подсчета элементов массива! ");
Console.Write("min: ");
int MinNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("max: ");
int MaxNumber = Convert.ToInt32(Console.ReadLine());

int SumElement = ElementCount(array, MinNumber, MaxNumber);
PrintArray(array);
Console.WriteLine($" -> {SumElement}");

int ElementCount(int[] arr, int min, int max)
{
    int sumElement = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= max && arr[i] >= min)
        {
            sumElement++;
        }
    }
    return sumElement;
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