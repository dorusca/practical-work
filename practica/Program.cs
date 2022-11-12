/* Задача 2: напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32 (Console.ReadLine ());
if (num1 > num2 )
{
    Console.WriteLine($"число {num1} является больше {num2}");
}
else
{
    Console.WriteLine($"число {num2} является больше {num1}");


}
Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32 (Console.ReadLine ());
int max = num1;

if ( num1 > max) max = num1;
if ( num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"число {max} является максимальным");




Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли щно без остатка)


Console.WriteLine("Введите  число");
int num = Convert.ToInt32 (Console.ReadLine ());
if ( num % 2 == 0)
{
    Console.WriteLine($"число {num} является четным");
}
else
{
    Console.WriteLine($"число {num} не является четным ");
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

*/

Console.WriteLine("Дорогой пользователь, введи N:");
int num = Convert.ToInt32(Console.ReadLine ());

int current = num / num ;
while (current <= num) 
{
    Console.Write (current + " ");
current++;
}