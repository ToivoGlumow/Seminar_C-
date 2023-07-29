/* Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 5 -> "1, 2, 3, 4, 5, 6" */


Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
SeqOutput(number);

void SeqOutput(int x)
{   
   if(x == 0) return;
   SeqOutput(x - 1);
   Console.Write($"{x}");
}