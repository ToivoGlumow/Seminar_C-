/* Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. */

Console.WriteLine("Введите два целых числа");
Console.Write("Первое число: ");
int fistnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (fistnumber > secondnumber)
{
    Console.WriteLine($"Первое число {fistnumber} наибольшее.");
    Console.WriteLine($"Второе число {secondnumber} наименьшее.");
}
else if (secondnumber > fistnumber)
{
    Console.WriteLine($"Второе число {secondnumber} наибольшее.");
    Console.WriteLine($"Первое число {fistnumber} наименьшее.");
}
else 
{
    Console.WriteLine("Числа равны.");
}