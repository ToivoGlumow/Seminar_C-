/* Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5  */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Кол-во цифр в числе {number} -> {Amount(number)}");

int Amount(int x)
{
    int amount = 0;
    int num = x;
    while (x != 0)
    {
        x = x / 10;
        amount++;
    }
    return num == 0 ? 1 : amount;
}
