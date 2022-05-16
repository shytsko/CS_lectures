// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArrayRandom(m, n);

PrintArray(array);

for (int i = 0; i < n; i++)
{
    int temp = array[0, i];
    array[0, i] = array[m-1, i];
    array[m-1, i] = temp;
}

Console.WriteLine();
PrintArray(array);


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

