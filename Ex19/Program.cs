/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 10000 || n > 99999) 
{
    Console.WriteLine("Число не пятизначное, введите пятизначное число: ");
n = Convert.ToInt32(Console.ReadLine());
}

if((n / 1 % 10 == n / 10000 % 10) & (n / 10 % 10 == n / 1000 % 10))
Console.WriteLine("да");

else
Console.WriteLine("нет");

