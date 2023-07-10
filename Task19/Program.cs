/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли 
оно палиндромом.
 */

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введено не пятизначное число.");
}
else
{
string palindrome = Palindrome(number);
Console.WriteLine(palindrome);
}


string Palindrome(int x)
{
    if (x % 10 != x / 10000) return "Число не является палиндромом.";
    x = x % 10000;
    x = x / 10;
    if (x % 10 != x / 100) return "Число не является палиндромом.";
    return "Число является палиндромом.";
}