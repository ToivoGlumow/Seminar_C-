/*  Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.*/

Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber == secondnumber * secondnumber)
{
    Console.WriteLine($"Число {firstnumber} является квадратом числа {secondnumber}.");
}
else if (secondnumber == firstnumber * firstnumber)
{
    Console.WriteLine($"Число {secondnumber} является квадратом числа {firstnumber}.");
}
else
{
    Console.WriteLine("Ни одно число не является квадратом другого.");
}