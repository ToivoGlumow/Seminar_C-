/*  Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет
является ли этот день выходным.*/

Console.Write("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number > 7)
{
    Console.WriteLine("Это не день недели.");
}
else if (number >= 6 && number <= 7)
{
    Console.WriteLine("Это выходной.");
}
else 
{
    Console.WriteLine("Это рабочий день.");
}