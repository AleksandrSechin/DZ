// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] numbers = new int[10];
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 1000);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Количество четных чисел: {count}");