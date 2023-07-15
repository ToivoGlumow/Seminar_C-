/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] array = CreateArrayRndInt(6, -50, 50);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Сумма элементов стоящих на нечетных позициях в массиве: ");
PrintArray(array);
int Number = SumNotEvenElement(array);
Console.WriteLine($" -> {Number}");

int SumNotEvenElement(int[] arr)
{
    int sumNumber = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sumNumber = sumNumber + arr[i];
    }
    return sumNumber;
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
