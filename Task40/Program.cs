/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник со сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

Console.WriteLine("Введите длину сторон треугольника.");
Console.Write("Первая сторона: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая сторона: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья сторона: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool existsTriangle = ExistsTriangle(side1, side2, side3);
Console.Write(existsTriangle ? "Треугольник с указанными сторонами существует" : 
"Треугольника с указанными сторонами не существует");

bool ExistsTriangle(int a, int b, int c)
{
    if ((a > b + c) || (b > a + c) || (c > a + b)) return false;
    else return true;
}
