/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите числа с клавиатуры:");
int count = 0;
int timeVariable = 0;

for (int i = 1; i > 0; i++)
{
    string timeString = Console.ReadLine();
    if(timeString == "" || timeString == string.Empty) break;
    else 
    {
        timeVariable = Convert.ToInt32(timeString);
        if (timeVariable > 0) count++;
    }
}
Console.WriteLine($"Количество чисел больше 0, введеных пользователем: {count}");