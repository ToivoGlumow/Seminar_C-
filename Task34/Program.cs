﻿/* Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


int[] array = CreateArrayRndInt(6, 100, 999);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: ");
PrintArray(array);
int Number = CountEvenNumbers(array);
Console.WriteLine($" -> {Number}");

int CountEvenNumbers(int[] arr)
{
    int sumNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sumNumber++;
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