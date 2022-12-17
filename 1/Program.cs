//Задача 1 Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()!);
int max = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;

Console.Write("max = ");
Console.WriteLine(max);