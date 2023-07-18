// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.  [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0


int[] numbers = new int[10];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1, 11);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < numbers.Length; j += 2)
{
    sum = sum + numbers[j];
}
Console.Write($"Сумма элементов: {sum}");