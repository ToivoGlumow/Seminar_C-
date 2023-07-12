/* Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B. */

Console.WriteLine("Введите два целых числа:");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число (должно быть положительное): ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0)
{
    Console.WriteLine("Введено неверное число!");
    return;
}

int result = DegNumber(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} -> {result}");

int DegNumber(int a, int b)
{
    int degNumber = 1;
    for (int i = 1; i <= b; i++)
    {
        degNumber = degNumber * a;
    }
    return degNumber;
}