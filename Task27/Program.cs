/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {result}");

int SumNumber(int x)
{
    int sum = 0;
    int num = x;
    while (x != 0)
    {
        x = x / 10;
        sum = sum + (num % 10);
        num = x;
    }
    return sum;
}
