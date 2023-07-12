/* Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {number} -> {Mult(number)}");

int Mult(int x)
{
    int mult = 1;
    for(int i = 1; i <= x; i++)
    {
        checked
        {
            mult = mult * i;
        }
        
    }
    return mult;
}