// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] numbers = new int[5, 5];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double result = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        result = result + numbers[i, j];
    }
    Console.WriteLine($"Среднее арифметическое {j + 1} столбца: {result / numbers.GetLength(0)} ");
}