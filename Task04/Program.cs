/* Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
 */

Console.WriteLine("Введите три числа");
Console.Write("Первое число: ");
int fistnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
int max = fistnumber;

if (max < secondnumber)
{
    max = secondnumber;
}
if (max < thirdnumber)
{
    max = thirdnumber;
}
 Console.WriteLine($"Максимальное число: {max}");
