// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArrayRandom(m, n);

PrintArray(array);

int i = 0;
int sum = 0;
while (i < m && i < n)
{
    sum += array[i, i];
    i++;
}

Console.WriteLine($"sum = {sum}");


int[,] CreateArrayRandom(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(-9, 10);

    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

