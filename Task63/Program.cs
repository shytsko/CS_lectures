// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 200;

MyRecurcion(n);

void MyRecurcion(int n)
{
    if (n == 1)
    {
        Console.Write(n);
    }
    else
    {
        MyRecurcion(n - 1);
        Console.Write($", {n}");
    }
}
