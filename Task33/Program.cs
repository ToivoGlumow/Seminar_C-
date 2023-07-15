/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

Console.WriteLine();
Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

if(FindNumber(array, number) == true)
{
Console.WriteLine( $"Число {number} есть в массиве.");
}
else Console.WriteLine( $"Числа {number} нет в массиве.");

bool FindNumber(int[] arr, int x)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (x == arr[i]) return true;
    }
    return false;
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