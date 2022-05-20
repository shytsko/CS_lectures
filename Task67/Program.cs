// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int n = 1111111111;

int sum = SumDigit(n);
Console.WriteLine(sum);

int SumDigit(int n)
{
    if (n < 10)
        return n;
    else
        return n % 10 + SumDigit(n / 10);
}
