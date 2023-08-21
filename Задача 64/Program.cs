// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// Выполнить с помощью рекурсии.  N = 5 -> "5, 4, 3, 2, 1"    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
string Numbers(int a, int n)
{
    if (a <= n)
    {
        return Numbers(a + 1, n) + $"{a} ";
    }
    else
        return String.Empty;
}
Console.WriteLine(Numbers(a, n));