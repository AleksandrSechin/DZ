// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4   17 -> такого числа в массиве нет


Console.Write("Введите значение строки для элемента массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца для элемента массива: ");
int num2 = Convert.ToInt32(Console.ReadLine());

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

if (num1 > numbers.GetLength(0) || num1 < 1 || num2 < 1 || num2 > numbers.GetLength(1))
{
    Console.WriteLine("Для указанных значений в массиве нет элемента");
}
else
{
    Console.WriteLine($"Значение элемента массива {numbers[num1-1, num2-1]}");
}