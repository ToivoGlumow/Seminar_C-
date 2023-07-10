/* адача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица: ");
Table(number);

void Table(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.WriteLine($"{count, 3}  {count * count, 5}");
        count++;
    }
}
