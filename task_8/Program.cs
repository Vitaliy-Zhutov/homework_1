/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

using static System.Console;

Write("Введите число: ");
int N = int.Parse(ReadLine()!);

int a = 2;

if(N > 1)
{
    while(a <= N)
    {
       //Write(a + " ");
       Write($"{a} {" "}");
       a = a + 2;
    }
}