/* Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что 
третьей цифры нет. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int estNumber = number;

if (number < 0)
{
    estNumber *= -1;
}

while (estNumber > 999)
{
    estNumber = estNumber / 10;
}
if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    Console.WriteLine($"Третья цифра числа {number} -> {estNumber % 10}");
}