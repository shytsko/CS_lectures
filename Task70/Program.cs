// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

int n1 = InputNumber("n1 = ");
int n2 = InputNumber("n2 = ");
int N = InputNumber("N = ");

OutputNumbers(n1, n2, N);

void OutputNumbers(int n1, int n2, int N)
{
    if (N == 2)
    {
        Console.Write($"{n1} {n2}");
    }
    else
    {
        Console.Write($"{n1} ");
        OutputNumbers(n2, n1 + n2, N - 1);
    }
}

int InputNumber(string message)
{
    Console.Write(message);
    return Int32.Parse(Console.ReadLine());
}