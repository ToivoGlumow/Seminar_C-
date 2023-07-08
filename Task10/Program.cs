/*  Напишите программу, которая принимает на
вход трехзначное число и на выходе показывает вторую
цифру этого числа.*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <= 999)
{
    Console.WriteLine($"Вторая цифра числа {number} -> {(number / 10) % 10}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}