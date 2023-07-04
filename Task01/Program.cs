/* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

Console.WriteLine("Введите два целых числа");
Console.Write("Первое число: ");
int fistnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (fistnumber == (secondnumber * secondnumber))
{
    Console.WriteLine($"Число {fistnumber} является квадратом числа {secondnumber}");
}
else
{
    Console.WriteLine($"Число {fistnumber} не является квадратом числа {secondnumber}");
}
