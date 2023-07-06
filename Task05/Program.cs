/* Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" */

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;

Console.WriteLine($"Числовая последовательность от {number * -1} до {number}:");
while (count != (number * -1)) // Или можно написать так: while (count != ((number + 1) * -1)) и тогда 17 строчка не нужна.
{
    Console.Write($"{count * -1}, ");
    count = count - 1;
}
Console.WriteLine($"{count * -1}.");