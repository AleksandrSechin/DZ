// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int[,] nums = new int[3, 4];

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

Print(nums);
Console.WriteLine();

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        for (int k = 0; k < nums.GetLength(1) - 1; k++)
        {
            if (nums[i, k] < nums[i, k + 1])
            {
                int temp = 0;
                temp = nums[i, k];
                nums[i, k] = nums[i, k + 1];
                nums[i, k + 1] = temp;
            }  
        }
    }
}    

Print(nums);