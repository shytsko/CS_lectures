// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countDigit = 0;

// while(number != 0)
// {
//     number /= 10;
//     countDigit++;
// }

for (int numberTemp = number; numberTemp != 0; numberTemp /= 10, countDigit++);

Console.WriteLine($"Количество цифр в числе {number}: {countDigit}");
