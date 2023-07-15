/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};
double result = MaxElement(array) - MinElement(array);
PrintArray(array);
Console.Write($" => {MaxElement(array)} - {MinElement(array)} = {result}");

double MaxElement(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxElement < arr[i]) maxElement = arr[i];
    }
    return maxElement;
}

double MinElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minElement > arr[i]) minElement = arr[i];
    }
    return minElement;
}

void PrintArray(double[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}