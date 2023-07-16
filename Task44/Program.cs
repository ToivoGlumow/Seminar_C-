/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.Write("Введите количество чисел Фибоначи: ");
int number = Convert.ToInt32(Console.ReadLine());
Fibonachi(number);

void Fibonachi(int x)
{
    int number1 = 0;
    int number2 = 0;
    int timeVariable = 0;
    if (x == 0 ) number1 = 0;
    if (x != 0) 
    {
        number1 = 0;
        number2 = 1;
    }
    Console.Write(Convert.ToBoolean(number1 + number2) ? $"Если N = {x} -> {number1} {number2} "
     : $"Если N = {x} -> {number1}");
     
    for (int i = x - 2; i > 0; i--)
    {
        Console.Write($"{number1 + number2} ");
        timeVariable = number2;
        number2 = number2 + number1;
        number1 = timeVariable;
    }
}