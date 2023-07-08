/* Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
 */

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Cordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1Coordinate, y1Cordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
Console.WriteLine($"Расстояние между точками равно {distance}.");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int cat1 = x1 - x2;
    int cat2 = y1 - y2;
    int cat3 = z1 - z2;
    double dist = Math.Sqrt((cat1 * cat1) + (cat2 * cat2) + (cat3 * cat3));
    return dist;
}