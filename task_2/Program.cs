﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using static System.Console;

Write ("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write ("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a > b)
{
WriteLine($"Большее число = {a}, меньшее число = {b}");
}
    else if (b > a)
    {
    WriteLine($"Большее число = {b} меньшее число = {a}");
    }
        else
        {
        WriteLine($"Число {b} равно числу {a}");
        }