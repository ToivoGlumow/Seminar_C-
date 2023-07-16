/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите значения b1, k1 для первой прямой");
Console.Write("k1 = ");
double coeff1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
double const1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения b2, k2 для второй прямой");
Console.Write("k2 = ");
double coeff2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double const2 = Convert.ToInt32(Console.ReadLine());

if(coeff1 == coeff2 && const1 == const2) Console.WriteLine("Прямые совпадают!");
if(coeff1 == coeff2) Console.WriteLine("Прямые параллельны!");
else 
{
    double[] coordResult = IntersectionPoint(coeff1, const1, coeff2, const2);
    Console.WriteLine($"b1 = {const1}, k1 = {coeff1}, b2 = {const2}, k2 = {coeff2} -> ({coordResult[0]}, {coordResult[1]})");
}



double[] IntersectionPoint(double x1, double y1, double x2, double y2)
{
    double[] coord = new double[2];
    coord[0] = (const1 - const2) / (coeff2 - coeff1);
    coord[1] = ((const2 * coeff1) - (const1 * coeff2)) / (coeff1 - coeff2);
    return coord;
}