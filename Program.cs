﻿/*Напишите программу, которая на вход принимает число и выдаёт его квадрат

Console.WriteLine("Введите число,квадрат которого надо найти ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine($"Квадрат {number} равен {result}");


// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine($"число {number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"число {number1} не является квадратом {number2}");
}



Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
 

Console.WriteLine("Дорогой пользователь, введи N:");
int num = Convert.ToInt32(Console.ReadLine ());

int current = num * (-1);
while (current <= num) 
{
    Console.Write (current + "  ");
current++;
}



Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number > 99 && number < 1000){
    int current =number % 10 ;
    Console.WriteLine ($"Последняя цифра числа {number} - {current}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}
*/