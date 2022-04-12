// Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N
// до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int start;
if (N > 0)
{
    start = 0 - N;
}
else
{
    start = N;
}
int end;
if (N > 0)
{
    end = N;
}
else
{
    end = 0 - N;
}
int i = start;
while (i <= end)
{
    Console.Write(i + ", ");
    i++;
}