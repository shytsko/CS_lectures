// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArrayRandom(m, n);

PrintArray(array);

int[,] mirrorArray = GetMirrorArray(array);

Console.WriteLine();
PrintArray(mirrorArray);


int[,] CreateArrayRandom(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(-9, 10);

    return array;
}

int[,] GetMirrorArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            newArray[j, i] = array[i, j];

    return newArray;
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

