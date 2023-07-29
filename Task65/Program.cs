/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

Console.WriteLine("Введите 2 натуральных числа N, M: ");

Console.WriteLine("Введите натуральное число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
while((number1 < 1) || ((number1 * 10) % 10) != 0)
{
    Console.WriteLine("Число не является натуральным, введите другое число: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите натуральное число M: ");
int number2 = Convert.ToInt32(Console.ReadLine());
while((number2 < 1) || ((number2 * 10) % 10) != 0)
{
    Console.WriteLine("Число не является натуральным, введите другое число: ");
    number2 = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"M = {number2}; N = {number1} -> ");
GapOutput(number1, number2);


void GapOutput(int x, int y)
{    
   if(x < y)
   {
    Console.Write($"{x} ");
    GapOutput(x + 1, y);
   }
   else if(x > y)
   {
    Console.Write($"{x} ");
    GapOutput(x - 1, y);
   }
   else 
   {
    Console.Write($"{x} ");
   }
}
