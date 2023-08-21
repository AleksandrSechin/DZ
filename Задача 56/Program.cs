// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

int[,] nums = new int[5, 3];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

void Print(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumRow(int[,] nums, int i)
{
    int sum = nums[i, 0];
    for (int j = 1; j < nums.GetLength(1); j++)
    {
        sum += nums[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumRow(nums, 0);
for (int i = 1; i < nums.GetLength(0); i++)
{
    if (sum > SumRow(nums, i))
    {
        sum = SumRow(nums, i);
        minSum = i + 1;
    }
}

Print(nums);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов имеет номер: {minSum}");
