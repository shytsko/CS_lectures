// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int number = 8;//new Random().Next(0, int.MaxValue);

int binSize = 0;

int tempNumber = number;
while (tempNumber != 0)
{
    tempNumber /= 2;
    binSize++;
}

int[] binArray = new int[binSize];
tempNumber = number;
for (int i = binArray.Length - 1; i >= 0; i--)
{
    binArray[i] = tempNumber % 2;
    tempNumber /= 2;
}

Console.WriteLine($"number = {number}");
PrintArray(binArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}