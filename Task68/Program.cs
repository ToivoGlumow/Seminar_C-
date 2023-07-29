/* Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int m = 3, n = 5;
int result = FuncAcker(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {result}");

int FuncAcker(int a, int b)
{
    if (a == 0) return b + 1;
    else if(b == 0) return FuncAcker(a - 1, 1);
    else return FuncAcker(a - 1, FuncAcker(a, b -1));
}