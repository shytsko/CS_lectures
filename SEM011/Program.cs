// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

int m = ReadInteger("Введите количество строк m=");
int n = ReadInteger("Введите количество столбцов n=");
int minimum = 0;
int maximum = 9;

int[,] array = CreateArrayRandom(m, n, minimum, maximum);
PrintArray(array);

int[] count = new int[maximum + 1];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        count[array[i, j]]++;
    }
}

for (int i = 0; i < count.Length; i++)
{
    if (count[i] != 0)
    {
        Console.WriteLine($"{i} встечается {count[i]} раз");
    }
}

int[,] CreateArrayRandom(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int ReadInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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