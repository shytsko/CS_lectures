﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int m = 54, n = 108;

MyRecurcion(m, n);

void MyRecurcion(int m, int n)
{
    if (n == m)
    {
        Console.Write(n);
    }
    else
    {
        MyRecurcion(m, n - 1);
        Console.Write($", {n}");
    }
}