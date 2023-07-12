/* Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {number} -> {Sum(number)}");

int Sum(int x)
{
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        checked
        {
            sum = sum + i;
        }
    }

    return sum;
}