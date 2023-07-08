/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string range = Range(quarter);

Console.WriteLine(range);

string Range(int x)
{
    if (x == 1) return "Координаты находятся в диапазоне: x > 0, y > 0";
    if (x == 2) return "Координаты находятся в диапазоне: x < 0, y > 0";
    if (x == 3) return "Координаты находятся в диапазоне: x < 0, y < 0";
    if (x == 4) return "Координаты находятся в диапазоне: x > 0, y < 0";
    return "Такого диапазона не существует";
}

/* void Range(int x)
{
    if (x == 1) Console.WriteLine ("Координаты находятся в диапазоне: x > 0, y > 0");
    if (x == 2) Console.WriteLine ("Координаты находятся в диапазоне: x < 0, y > 0");
    if (x == 3) Console.WriteLine ("Координаты находятся в диапазоне: x < 0, y < 0");
    if (x == 4) Console.WriteLine ("Координаты находятся в диапазоне: x > 0, y < 0");
    if (x > 4 && x < 1) Console.WriteLine("Такого диапазона не существует");
} */