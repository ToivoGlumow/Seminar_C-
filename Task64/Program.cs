/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

while((number < 1) || ((number * 10) % 10) != 0)
{
    Console.WriteLine("Число не является натуральным, введите другое число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"N = {number} -> ");
SeqOutput(number);

void SeqOutput(int x)
{    
   if(x == 0) return;
   Console.Write($"{x} ");
   SeqOutput(x - 1);
}
 