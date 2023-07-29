/* Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите 2 натуральных числа N, M: ");

Console.WriteLine("Введите натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
while((number1 < 1) || ((number1 * 10) % 10) != 0)
{
    Console.WriteLine("Число не является натуральным, введите другое число: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите натуральное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
while((number2 < 1) || ((number2 * 10) % 10) != 0)
{
    Console.WriteLine("Число не является натуральным, введите другое число: ");
    number2 = Convert.ToInt32(Console.ReadLine());
}

if(number1 == number2) Console.WriteLine("Между M и N нет чисел.");
else
{
    int sumGap = SumGapOutput(number1, number2);
    Console.Write($"M = {number1}; N = {number2} -> {sumGap}");
}



int SumGapOutput(int x, int y)
{  
   if(x < y)
   {
    return x + SumGapOutput(x + 1, y);
   }
   else if(x > y)
   {
    return x + SumGapOutput(x - 1, y);
   }
   else 
   { 
    return x;
   }
}
