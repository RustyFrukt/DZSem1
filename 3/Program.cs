﻿//Задача 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите  число: ");
int numA = int.Parse(Console.ReadLine()!);
if (numA % 2 == 0)
{
    Console.WriteLine("это четное число");
}
else
{
    Console.WriteLine("это нечетное число");
}