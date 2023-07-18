// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = new double[7];
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    numbers[j] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    Console.Write(numbers[j] + " ");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"Разность между максимальным и минимальным {max} - {min} = {max - min}");



























