/*  Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число не кратно
второму, то программа выводит остаток от деления.*/

Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
int fistnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if ((fistnumber % secondnumber) == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {fistnumber % secondnumber}");
}