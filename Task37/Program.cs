/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] array = CreateArrayRndInt(6, 0, 9);
PrintArray(array);
Console.Write(" -> ");

int[] resultArray = MultPairsElements(array);
PrintArray(resultArray);

int[] MultPairsElements(int[] arr)
{
    int lengthArray = 0;
    if (arr.Length % 2 == 0) lengthArray = arr.Length / 2;
    else lengthArray = (arr.Length / 2) + 1;
    
    int[] multArray = new int[lengthArray];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        multArray[lengthArray - 1] = arr[arr.Length / 2];
        multArray[i] = arr[i] * arr[(arr.Length - 1) - i];
    }
    return multArray;
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