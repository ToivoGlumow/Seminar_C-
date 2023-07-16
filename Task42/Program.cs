/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = TranslationToBinary(number);
Console.Write($"{number} -> ");
PrintArray(array);

int[] TranslationToBinary(int x)
{
    int size = 0;
    for (int i = number; i != 0; i = i / 2)
    {
        size++;
    }
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[(size - 1) - i] = x % 2;
        x = x / 2;
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

